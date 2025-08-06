using CapaEntidades;
/*
   UNED SEGUNDO CUATRIMESTRE 2025
   PROYECTO 2:Agregar nuevas funcionalidades al software de la  empresa Entregas S.A
   Estudiante:Justin Paniagua Solano
   Cedula:305530632
   Fecha :27/7/2025
*/

namespace ClienteCapaPresentacion
{
    public partial class FrmConsultas : Form
    {
        //Instancias de las clases necesarias
        private Clientes clienteSesion;
        private FrmMenuCliente FrmMenu;

        public FrmConsultas(Clientes cliente, FrmMenuCliente FrmMenu)
        {
            InitializeComponent();
            this.clienteSesion = cliente;
            this.FrmMenu = FrmMenu;
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            CargarColumasYFilas();// Cargar las columnas y filas del DataGridView
            //Cargar los datos del cliente en las etiquetas
            LblNombre.Text = "Conectado como: " + clienteSesion.Nombre+" "+clienteSesion.PrimerApellido+" "+clienteSesion.SegundoApellido;
            LblIdentificacion.Text ="Identificacion:" + clienteSesion.Identificacion.ToString();
            // Cambiar el color de las etiquetas
            LblNombre.ForeColor = Color.Green;
            LblIdentificacion.ForeColor = Color.Green;
        }

        //Metodo para cargar las columnas y filas del DataGridView
        private void CargarColumasYFilas()
        {
            // Método para cargar las columnas y filas del DataGridView
            //Idea sacada de la tutoria de Johan Acosta:
            //https://www.youtube.com/watch?v=2IWiBqwDgKM
            DgvConsulta.DataSource = null;
            DgvConsulta.Rows.Clear();
            DgvConsulta.Columns.Clear();

            //Definicion de la columna y celda ID
            DataGridViewColumn NuevaColumna = new DataGridViewColumn();
            DataGridViewCell NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "ID";
            NuevaColumna.Name = "ID";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            //definicion de la columna y celda Nombre
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Articulo";
            NuevaColumna.Name = "Articulo";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Tipo Articulo";
            NuevaColumna.Name = "Tipo Articulo";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            //definicion de la columna y celda Valor
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Fecha Pedido";
            NuevaColumna.Name = "Fecha Pedido";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            //definicion de la columna y celda Inventario
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Cantidad";
            NuevaColumna.Name = "Cantidad";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;


            // Agregar la columna al DataGridView
            DgvConsulta.Columns.Add(NuevaColumna);
        }
        //metodo para cargar los datos a DGV
        private void CargarDatosDGV()
        {
            DgvConsulta.Rows.Clear();

            if (clienteSesion == null)
                return;

            // Obtener los pedidos del cliente y los artículos activos
            var pedidos = ClienteTCP.ConsultarMisPedidos(clienteSesion.Identificacion.ToString());
            var articulos = ClienteTCP.ObtenerArticulos();

            foreach (var pedido in pedidos)
            {
                List<DetallesPedido> detalles = ClienteTCP.ObtenerDetallesPorNumeroPedido(pedido.NumeroPedido);

                foreach (var detalle in detalles)
                {
                    // Buscar el artículo 
                    Articulos articuloEncontrado = null;
                    foreach (var articulo in articulos)
                    {
                        if (articulo.Id == detalle.IDArticulo)
                        {
                            articuloEncontrado = articulo;
                            break;
                        }
                    }

                    detalle.Articulos = articuloEncontrado;
                }

                foreach (var detalle in detalles)
                {
                    DgvConsulta.Rows.Add(
                        pedido.NumeroPedido,
                        detalle.Articulos != null ? detalle.Articulos.Nombre : "N/A",
                        (detalle.Articulos != null && detalle.Articulos.TiposArticulos != null)
                            ? detalle.Articulos.TiposArticulos.Nombre
                            : "N/A",
                        pedido.FechaPedido.ToShortDateString(),
                        detalle.Cantidad
                    );
                }
            }
        }
        
        //Boton Menu
        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu.Show();
            this.Close();
        }
        //Boton para consultar todos los pedidos
        private void BttConsultasTodos_Click(object sender, EventArgs e)
        {
            CargarDatosDGV();// Cargar los datos en el DataGridView
        }
        //Boton para consultar por numero de pedido
        private void BttConsularNumeroPedido_Click(object sender, EventArgs e)
        {
            MostrarDetallesPorID();// Mostrar los detalles del pedido por ID
        }

        //Metodo para mostrar los detalles del pedido por ID
        private void MostrarDetallesPorID()
        {
            DgvConsulta.Rows.Clear();
            //Diferentes tipos de validaciones
            if (string.IsNullOrWhiteSpace(TxtNumeroPedido.Text))
            {
                MessageBox.Show("Ingrese un número de pedido.");
                return;
            }

            if (!int.TryParse(TxtNumeroPedido.Text, out int numeroPedido))
            {
                MessageBox.Show("El número de pedido debe ser numérico.");
                return;
            }

            if (clienteSesion == null)
            {
                MessageBox.Show("Sesión de cliente no iniciada.");
                return;
            }

            var pedido = ClienteTCP.ConsultarPedidoPorId(clienteSesion.Identificacion.ToString(), numeroPedido);

            if (pedido == null)
            {
                MessageBox.Show("Pedido no encontrado o no pertenece a este cliente.");
                return;
            }

            var articulos = ClienteTCP.ObtenerArticulos();
            var detalles = ClienteTCP.ObtenerDetallesPorNumeroPedido(numeroPedido);

            if (detalles == null || detalles.Count == 0)
            {
                MessageBox.Show("Este pedido no tiene detalles registrados.");
                return;
            }

            foreach (var detalle in detalles)
            {
                // Buscar el artículo 
                Articulos articuloEncontrado = null;
                foreach (var art in articulos)
                {
                    if (art.Id == detalle.IDArticulo)
                    {
                        articuloEncontrado = art;//Asignar el artículo encontrado
                        break;
                    }
                }

                string nombreArticulo = (articuloEncontrado != null) ? articuloEncontrado.Nombre : "N/A";
                string tipoArticulo = (articuloEncontrado != null && articuloEncontrado.TiposArticulos != null)
                                        ? articuloEncontrado.TiposArticulos.Nombre
                                        : "N/A";

                DgvConsulta.Rows.Add(
                    numeroPedido,
                    nombreArticulo,
                    tipoArticulo,
                    pedido.FechaPedido.ToShortDateString(),
                    detalle.Cantidad
                );
            }
        }


    }
}
    



