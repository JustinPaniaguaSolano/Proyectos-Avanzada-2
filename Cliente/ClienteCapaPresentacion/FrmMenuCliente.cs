using CapaEntidades;
using CapaPresentacion;

/*
   UNED SEGUNDO CUATRIMESTRE 2025
   PROYECTO 2:Agregar nuevas funcionalidades al software de la  empresa Entregas S.A
   Estudiante:Justin Paniagua Solano
   Cedula:305530632
   Fecha :27/7/2025
*/

namespace ClienteCapaPresentacion
{
    public partial class FrmMenuCliente : Form
    {
        private string identificacionClienteActual;
        private Clientes clienteActual;
        public FrmMenuCliente()
        {
            InitializeComponent();
            //Configuracion inicial de los botones de la ventana
            BttAgregarPedidos.Enabled = false;
            BttConsultarPedidos.Enabled = false;
            BttDesconectar.Enabled = false;
            BttConectar.BackColor=Color.Green;
            BttDesconectar.BackColor = Color.LightCoral;
            TxtIdentificacion.BackColor = Color.White;
            BttAgregarPedidos.BackColor = Color.Gray;
            BttConsultarPedidos.BackColor = Color.Gray;
        }
        //Boton conectar al servidor y validar cliente
        private void BttConectar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TxtIdentificacion.Text))
            {
                if (ClienteTCP.Conectar(TxtIdentificacion.Text))// Conectar al servidor con el identificador del cliente
                {
                    if (ClienteTCP.ValidarCliente(TxtIdentificacion.Text))// Validar si el cliente existe en el servidor
                    {
                        identificacionClienteActual = TxtIdentificacion.Text;
                        clienteActual = ClienteTCP.ObtenerClientePorIdentificacion(identificacionClienteActual);// Obtener el cliente actual por su identificacion
                        //Cambio graficos en la ventana
                        LblEstado.Text = "Conectado al servidor (127.0.0.1, 14100)";
                        LblEstado.ForeColor = Color.Green;
                        BttConectar.Enabled = false;
                        BttDesconectar.Enabled = true;
                        TxtIdentificacion.ReadOnly = true;
                        LblCliente.Text = ClienteTCP.NombreCliente;
                        LblIdentificacion.Text = clienteActual.Identificacion.ToString();
                        BttConectar.BackColor = Color.White;

                        // Mensaje de bienvenida y habilitar botones
                        MessageBox.Show("Bienvenido"+" "+clienteActual.Nombre);
                        BttAgregarPedidos.Enabled = true;
                        BttConsultarPedidos.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show("Error:Verifique que el servidor esta activo y que el cliente este registrado...");
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar el identificador del cliente");
            }
        }
        // Boton para desconectar del servidor
        private void BttDesconectar_Click(object sender, EventArgs e)
        {
            ClienteTCP.Desconectar(TxtIdentificacion.Text);// Desconectar del servidor con el identificador del cliente

            //cambios graficos en la ventana
            LblEstado.Text = "Desconectado del servidor...";
            LblEstado.ForeColor = Color.Red;
            BttConectar.Enabled = true;
            BttDesconectar.Enabled = false;
            TxtIdentificacion.ReadOnly = false;
            TxtIdentificacion.Text = string.Empty;
            LblCliente.Text = "..";
            LblIdentificacion.Text = "..";
            BttConectar.BackColor = Color.Green;

            MessageBox.Show("Adios"+" "+ clienteActual.Nombre);
        }
        //Boton para agregar pedidos
        private void BttAgregarPedidos_Click(object sender, EventArgs e)
        {
            //Validar que el cliente tenga artículos activos para poder agregar un pedido
            List<Articulos> articulosActivos = ClienteTCP.ObtenerArticulosActivos();
            if (articulosActivos == null || articulosActivos.Count == 0)
            {
                MessageBox.Show("No hay artículos activos disponibles.Comuniquese con el Administrador");
                return;
            }
            else//Si existen artículos activos se abre la ventana de pedidos
            {
                FrmPedidos ventana = new FrmPedidos(clienteActual, this);
                ventana.Show();
                this.Hide();
            }
           
        }
        // Boton para consultar pedidos
        private void BttConsultarPedidos_Click(object sender, EventArgs e)
        {
            //Validar que el cliente tenga pedidos registrados
            var pedidos = ClienteTCP.ConsultarMisPedidos(clienteActual.Identificacion.ToString());
            if (pedidos == null || pedidos.Count == 0)
            {
                MessageBox.Show("No tiene pedidos registrados.Debe de registrar un pedido para poder consultarlo");
                return;
            }
            else//Si tiene pedidos guardados se abre la ventana de consultas
            {
                FrmConsultas ventana = new FrmConsultas(clienteActual, this);
                ventana.Show();
                this.Hide();
            }
        }
    }
}
