using CapaEntidades;
using CapaLogicaNegocio;
using CapaPresentacion;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

/*
   UNED SEGUNDO CUATRIMESTRE 2025
   PROYECTO 2:Agregar nuevas funcionalidades al software de la  empresa Entregas S.A
   Estudiante:Justin Paniagua Solano
   Cedula:305530632
   Fecha :27/7/2025
*/
namespace ServidorCapaPresentacion
{
    public partial class FrmMenuServidor : Form
    {
        // Instancias de las clases de la capa de negocio
        private readonly ComunicacionTCP comunicacionTCP = new ComunicacionTCP();
        private readonly PedidosN pedidosN = new PedidosN();
        private readonly ClientesN ClientesN = new ClientesN();
        private readonly ArticulosN articulosN = new ArticulosN();
        private readonly RepartidoresN RepartidoresN = new RepartidoresN();
        private readonly DetallesPedidoN DetallesN = new DetallesPedidoN();

        // Delegados para actualizar la interfaz de usuario desde un hilo diferente
        private delegate void EscribirEnTextoDelegado(string texto);
        private delegate void ModificarTextoDeletado(string texto, bool agregar);

        // Constructor de la clase FrmMenuServidor
        EscribirEnTextoDelegado ModificarBitacora;
        ModificarTextoDeletado ModificarListBoxClientes;

        public FrmMenuServidor()
        {
            InitializeComponent();
            comunicacionTCP.MensajeRecibido += ComunicacionTCP_MensajeRecibido;
            ModificarBitacora = new EscribirEnTextoDelegado(EscribirEnBitacora);
            ModificarListBoxClientes = new ModificarTextoDeletado(ModificarListBox);
            BttIniciarServidor.BackColor= Color.LightGreen; // Cambiar el color del botón de iniciar servidor a verde
            BttDetenerServidor.BackColor = Color.LightCoral; // Cambiar el color del botón de detener servidor a rojo
        }
        // Método para Recibir mensajes del cliente y procesarlos
        private void ComunicacionTCP_MensajeRecibido(object sender, (string mensaje, StreamWriter streamWriter) e)
        {
            try
            {
                var mensajeRecibido = JsonConvert.DeserializeObject<MensajeSocket<JObject>>(e.mensaje);
                SeleccionarMetodo(mensajeRecibido.Metodo, mensajeRecibido.Entidad, ref e.streamWriter);
            }
            catch (JsonException ex)
            {
                MessageBox.Show("Error al deserializar el mensaje recibido. Asegúrese de que el formato del mensaje sea correcto.\nDetalles: " + ex.Message, "Error de Deserialización", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al procesar el mensaje recibido: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Metodo para escribir en la bitacora
        private void EscribirEnBitacora(string texto)
        {
            TxtBitacora.AppendText(DateTime.Now.ToString() + "-" + texto);
            TxtBitacora.AppendText(Environment.NewLine);
        }

        //Metodo para escribir en el ListBox de clientes
        private void ModificarListBox(string texto, bool agregar)
        {
            if (agregar)
            {
                TxtClientes.Items.Add(texto);
            }
            else
            {
                TxtClientes.Items.Remove(texto);
            }
        }

        //Boton para iniciar el servidor
        private void BttIniciarServidor_Click(object sender, EventArgs e)
        {
            comunicacionTCP.Iniciar();
            //Escribir en la bitacora que el servidor se ha iniciado
            TxtBitacora.Text = "Servidor iniciado(127.0.0.1 puerto 14100)";
            TxtBitacora.AppendText(Environment.NewLine);
            LblEstadoServidor.Text = "Conectado";
            BttIniciarServidor.Enabled = false; // Deshabilitar el botón de iniciar servidor
            LblEstadoServidor.ForeColor = Color.Green; // Cambiar el color del estado a verde
            BttDetenerServidor.Enabled = true; // Habilitar el botón de detener servidor
        }

        //Boton para detener el servidor
        private void BttDetenerServidor_Click(object sender, EventArgs e)
        {
            comunicacionTCP.Detener();
            //Escribir en la bitacora que el servidor se ha detenido
            TxtBitacora.Text = "Servidor Detenido";
            TxtBitacora.AppendText(Environment.NewLine);
            LblEstadoServidor.Text = "Desconectado";
            BttIniciarServidor.Enabled = true;
            LblEstadoServidor.ForeColor = Color.Firebrick; // Cambiar el color del estado a rojo
            BttDetenerServidor.Enabled = false; // Deshabilitar el botón de detener servidor
        }

        // Método para enviar una respuesta al cliente
        private void EnviarRespuesta(string respuesta, ref StreamWriter servidorStreamWriter)
        {
            try
            {
                servidorStreamWriter.WriteLine(respuesta);
                servidorStreamWriter.Flush();
            }
            catch
            {
                // Manejo de excepciones al enviar la respuesta
                MessageBox.Show("No fue posible enviar los datos del stream writer");
            }
        }

        #region switch de metodos
        // Método para seleccionar el método a ejecutar según el mensaje recibido
        private void SeleccionarMetodo(string pMetodo, JToken entidad, ref StreamWriter servidorStreamWriter)
        {
            switch (pMetodo)
            {
                //Caso para conectar el cliente al servidor
                case "Conectar":
                    Conectar((string)entidad, ref servidorStreamWriter);//Llamado del metodo Conectar
                    break;

                // Caso para desconectar el cliente del servidor
                case "Desconectar":
                    Desconectar((string)entidad);//Llamado del metodo Desconectar

                    break;

                //Caso para validar si el cliente existe en la base de datos
                case "ValidarCliente":
                    ValidarCliente(entidad.ToObject<string>(), ref servidorStreamWriter);//Llamado del metodo ValidarCliente
                    break;

                //Caso para obtener el cliente por su identificacion
                case "ObtenerClientePorIdentificacion":
                    ObtenerClientePorIdentificacion(entidad, ref servidorStreamWriter);//Llamado del metodo ObtenerClientePorIdentificacion
                    break;

                //Caso para agregar un pedido a la base de datos
                case "AgregarPedido":
                    var datos = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonConvert.SerializeObject(entidad));
                    var pedido = JsonConvert.DeserializeObject<Pedidos>(datos["Pedido"].ToString());
                    var detalles = JsonConvert.DeserializeObject<List<DetallesPedido>>(datos["Detalles"].ToString());
                    AgregarPedido(pedido, detalles, ref servidorStreamWriter);
                    break;

                // Caso para obtener los repartidores de la base de datos
                case "ObtenerRepartidores":
                    ObtenerRepartidores(ref servidorStreamWriter);
                    break;

                // Caso para obtener los articulos activos de la base de datos
                case "ObtenerArticulosActivos":
                    ObtenerArticulosActivos(ref servidorStreamWriter);
                    break;

                // Caso para obtener el detalle de un articulo por su id
                case "ObtenerDetalleArticulo":
                    int idArticulo = Convert.ToInt32(entidad);
                    ObtenerDetalleArticulo(idArticulo, ref servidorStreamWriter);
                    TxtBitacora.Invoke(ModificarBitacora, new object[] { $"Consulta de detalle del articulo con ID: {idArticulo}" });
                    break;

                // Caso para consultar los pedidos de un cliente por su id
                case "ConsultarPedidosCliente":
                    ConsultarPedidosCliente(entidad.ToString(), ref servidorStreamWriter);
                    break;

                // Caso para obtener los detalles de un pedido por su numero de pedido
                case "ObtenerDetallesPorNumeroPedido":
                    int numPedido = JsonConvert.DeserializeObject<int>(JsonConvert.SerializeObject(entidad));
                    ObtenerDetallesPorNumeroPedido(numPedido, ref servidorStreamWriter);

                    break;

                // Caso para consultar un pedido por su id y cliente
                case "ConsultarPedidoPorId":
                    string idCliente1 = entidad["Identificacion"]?.ToString();
                    int numeroPedido = entidad["IdPedido"]?.ToObject<int>() ?? 0;
                    ConsultarPedidoPorId(idCliente1, numeroPedido, ref servidorStreamWriter);
                    break;
                //Caso para obtener todos los articulos de la base de datos
                case "ObtenerArticulos":
                    var articulos = articulosN.ObtenerArticulos();
                    EnviarRespuesta(JsonConvert.SerializeObject(articulos), ref servidorStreamWriter);
                    break;

                //Default case para manejar metodos no implementados
                default:
                    break;
            }
        }
        #endregion

        #region desarrollo de metodos para manejar los mensajes del cliente
        //Metodo para conectar un cliente al servidor
        private void Conectar(string pIdentificadorCliente, ref StreamWriter writer)
        {
            // Validar si el cliente existe en base de datos
            ClientesN clientesN = new ClientesN();
            var cliente = clientesN.BuscarClientePorIdentificacion(pIdentificadorCliente);

            if (cliente != null && cliente.Activo)
            {
                // Mostrar en bitácora y en la lista de clientes
                TxtBitacora.Invoke(ModificarBitacora, new object[] { pIdentificadorCliente + " se ha conectado..." });
                TxtClientes.Invoke(ModificarListBoxClientes, new object[] { pIdentificadorCliente, true });

                // Enviar nombre completo al cliente
                string nombreCompleto = $"{cliente.Nombre} {cliente.PrimerApellido} {cliente.SegundoApellido}";
                EnviarRespuesta(nombreCompleto, ref writer);// Enviar nombre completo al cliente
            }
            else
            {
                // Enviar "NO_EXISTE" en cade que el cliente no exista
                EnviarRespuesta("NO_EXISTE", ref writer);
            }
        }

        // Metodo para desconectar un cliente
        private void Desconectar(string pIdentificadorCliente)
        {
            TxtBitacora.Invoke(ModificarBitacora, new object[] { pIdentificadorCliente + " se ha desconectado!" });
            TxtClientes.Invoke(ModificarListBoxClientes, new object[] { pIdentificadorCliente, false });
        }

        //Metodo para agregar pedido
        private void AgregarPedido(Pedidos pedido, List<DetallesPedido> detalles, ref StreamWriter writer)
        {
            try
            {
                bool exito = pedidosN.AgregarPedido(pedido, detalles);

                if (exito)
                {
                    EnviarRespuesta("true", ref writer);
                    TxtBitacora.Invoke(ModificarBitacora, new object[] { $"Se agrego un Pedido,echo por el cliente:{pedido.clientes}" });
                }
                else
                {
                    EnviarRespuesta("ErrorInsertandoPedido", ref writer);
                }
            }
            catch (Exception ex)
            {
                EnviarRespuesta("ErrorServidor:" + ex.Message, ref writer);
            }
        }

        //Metodo para validar que el cliente exista
        private void ValidarCliente(string identificacion, ref StreamWriter servidorStreamWriter)
        {
            bool existe = ClientesN.ExisteCliente(identificacion); // llamado al metodo que valida si el cliente existe

            EnviarRespuesta(existe.ToString().ToLower(), ref servidorStreamWriter);
        }
        //Metodo para obtener el cliente de la base de datos de acuerdo a su identificacion
        private void ObtenerClientePorIdentificacion(object entidad, ref StreamWriter writer)
        {
            try
            {
                // Convertir la entidad al tipo correcto 
                string identificacion = entidad.ToString();

                var cliente = ClientesN.BuscarClientePorIdentificacion(identificacion);
                //Uso del operador Fusion Null para manejar el caso en que el cliente no exista
                //Sacado de https://builtin.com/articles/null-coalescing-operator-c
                var clienteRespuesta = cliente ?? new Clientes
                {
                    Identificacion = 0,
                    Nombre = "",
                    PrimerApellido = "",
                    SegundoApellido = "",
                    FechaNacimiento = DateTime.Now,
                    Activo = false
                };

                string respuestaJson = JsonConvert.SerializeObject(clienteRespuesta);
                EnviarRespuesta(respuestaJson, ref writer);
            }
            catch (Exception ex)
            {
                EnviarRespuesta("ErrorServidor: " + ex.Message, ref writer);
            }
        }

        //Metodo para obtener los repartidores de la base de datos
        private void ObtenerRepartidores(ref StreamWriter servidorStreamWriter)
        {
            var lista = RepartidoresN.ObtenerRepartidores();
            EnviarRespuesta(JsonConvert.SerializeObject(lista), ref servidorStreamWriter);
        }

        //Metodo para Obtener los articulos activos desde el servidor
        private void ObtenerArticulosActivos(ref StreamWriter writer)
        {
            var articulos = articulosN.ObtenerArticulos();
            List<Articulos> ArticulosActivos = new List<Articulos>();
            //Recorrer los articulos y buscar los activos
            foreach (var articulo in articulos)
            {
                if (articulo.Activo)
                {
                    ArticulosActivos.Add(articulo);
                }
            }

            EnviarRespuesta(JsonConvert.SerializeObject(ArticulosActivos), ref writer);// Enviar la lista de artículos activos al cliente
        }

        //Metodo para obtener los detalles de un articulo por su id
        private void ObtenerDetalleArticulo(int idArticulo, ref StreamWriter writer)
        {
            var articulos = articulosN.ObtenerArticulos();
            Articulos articulo = null;

            foreach (var art in articulos)
            {
                if (art.Id == idArticulo)
                {
                    articulo = art;//Se asigna el articulo encontrado
                    break;
                }
            }

            EnviarRespuesta(JsonConvert.SerializeObject(articulo), ref writer);
        }

        //Metodo para consultar los pedidos de un cliente por su id(todos su pedidos)
        private void ConsultarPedidosCliente(string idClienteConsulta, ref StreamWriter writer)
        {
            var pedidosCliente = PedidosN.ObtenerPedidosPorCliente(idClienteConsulta);
            string respuestaPedidos = JsonConvert.SerializeObject(pedidosCliente);
            EnviarRespuesta(respuestaPedidos, ref writer);
            TxtBitacora.Invoke(ModificarBitacora, new object[] { $"Consulta de pedidos para cliente: {idClienteConsulta}" });
        }

        //Metodo para obtener los detalles de un pedido por su numero de pedido
        private void ObtenerDetallesPorNumeroPedido(int numeroPedido, ref StreamWriter writer)
        {
            var detalles = DetallesN.ObtenerDetallesPorNumeroPedido(numeroPedido);
            EnviarRespuesta(JsonConvert.SerializeObject(detalles), ref writer);
            TxtBitacora.Invoke(ModificarBitacora, new object[] { $"Se realizo una consulta del pedido: {numeroPedido}" });
        }

        //Metodo para consultar un pedido por su id y cliente
        private void ConsultarPedidoPorId(string idCliente, int numeroPedido, ref StreamWriter writer)
        {
            try
            {
                var pedidoEncontrado = PedidosN.ObtenerPedidoPorId(numeroPedido);
                int idClienteInt = int.Parse(idCliente);

                if (pedidoEncontrado != null && pedidoEncontrado.clientes != null)
                {
                    if (pedidoEncontrado.clientes.Identificacion == idClienteInt)
                    {
                        // Obtener detalles
                        var TodosDetalles = DetallesN.ObtenerDetallesPorNumeroPedido(numeroPedido);
                        List<object> listaDetalles = new List<object>();

                        foreach (var detalle in TodosDetalles)
                        {
                            listaDetalles.Add(new
                            {
                                IdArticulo = detalle.IDArticulo,
                                TipoArticulo = (detalle.Articulos != null && detalle.Articulos.TiposArticulos != null) ? detalle.Articulos.TiposArticulos.Nombre : null,
                                Cantidad = detalle.Cantidad
                            });
                        }

                        var resultado = new
                        {
                            FechaPedido = pedidoEncontrado.FechaPedido,
                            Detalles = listaDetalles
                        };

                        string respuesta = JsonConvert.SerializeObject(resultado);
                        EnviarRespuesta(respuesta, ref writer);
                    }
                    else
                    {
                        EnviarRespuesta("NO_ENCONTRADO", ref writer);
                    }
                }
                else
                {
                    EnviarRespuesta("NO_ENCONTRADO", ref writer); // No se encontró el pedido o no tiene cliente
                }
            }
            catch (Exception ex)
            {
                EnviarRespuesta("ERROR: " + ex.Message, ref writer);
            }
        }

        #endregion

        #region Navegación entre formularios
        //Boton TiposArticulos
        private void BttRegis_Cons_TiposArticulos_Click(object sender, EventArgs e)
        {
            FrmTiposArticulos ventana = new FrmTiposArticulos(this);
            ventana.Show();
            this.Hide();
        }

        //Boton Articulos
        private void Btt_Regis_Cons_Articulos_Click(object sender, EventArgs e)
        {
            FrmArticulos ventana = new FrmArticulos(this);
            ventana.Show();
            this.Hide();
        }

        //Boton Clientes
        private void Btt_Regis_Cons_Clientes_Click(object sender, EventArgs e)
        {
            FrmClientes ventana = new FrmClientes(this);
            ventana.Show();
            this.Hide();
        }

        //Boton Repartidores
        private void BttRegis_Cons_Repartidores_Click(object sender, EventArgs e)
        {
            FrmRepartidor ventana = new FrmRepartidor(this);
            ventana.Show();
            this.Hide();
        }

        //Boton Pedidos
        private void Btt_Regis_Pedidos_Click(object sender, EventArgs e)
        {
            FrmPedidos ventana = new FrmPedidos(this);
            ventana.Show();
            this.Hide();
        }

        //Boton Consultar Pedidos y Detalles
        private void Btt_Cons_Pedidos_Click(object sender, EventArgs e)
        {
            FrmConsPedidosYDetalles ventana = new FrmConsPedidosYDetalles(this);
            ventana.Show();
            this.Hide();
        }
        #endregion
        // Evento de carga del formulario
        private void FrmMenuServidor_Load(object sender, EventArgs e)
        {
            comunicacionTCP.ClienteRechazado += (sender, mensaje) =>
            {
                TxtBitacora.Invoke(ModificarBitacora, new object[] { mensaje + "\r\n" });
            };
        }
    }
}
    



