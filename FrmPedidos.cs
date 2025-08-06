using CapaEntidades;
using CapaLogicaNegocio;
using ServidorCapaPresentacion;

/*
   UNED SEGUNDO CUATRIMESTRE 2025
   PROYECTO 2:Agregar nuevas funcionalidades al software de la  empresa Entregas S.A
   Estudiante:Justin Paniagua Solano
   Cedula:305530632
   Fecha :27/7/2025
*/
namespace CapaPresentacion
{
    public partial class FrmPedidos : Form
    {
        //Instancias de las clases de negocio
        private PedidosN PedidosN = new PedidosN();
        private ClientesN ClientesN = new ClientesN();
        private RepartidoresN RepartidoresN = new RepartidoresN();
        private int NumeroPedido = 0;
        private FrmMenuServidor FrmMenu;

        public FrmPedidos(FrmMenuServidor FrmMenu)
        {
            InitializeComponent();
            this.FrmMenu = FrmMenu;
        }

        //Boton Menu
        private void BttMenu_Click(object sender, EventArgs e)
        {
            FrmMenu.Show();
            this.Close();
        }
        //Boton para guardar el pedido
        private void BttGuardar_Click(object sender, EventArgs e)
        {
            // Llama al método ValidarCampos para validar los campos del formulario
            Pedidos pedidos = ValidarCampos();
            if (pedidos == null)
                return;

            int idGenerado = PedidosN.AgregarPedidoYObtenerId(pedidos);

            if (idGenerado > 0)
            {
                MessageBox.Show("Pedido guardado correctamente");
                FrmDetallescs ventana = new FrmDetallescs(idGenerado,FrmMenu); // ← se pasa el ID 
                ventana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error al guardar el pedido");
            }
        }
        //Metodo para validar los campos ingresados por el usuario
        private Pedidos ValidarCampos()
        {
            try
            {
                
                //validar direccion
                if (string.IsNullOrEmpty(TxtDireccion.Text.Trim()))
                {
                    throw new Exception("Debe digitar la dirección del pedido");
                }

                //validar cliente
                if (CmbCliente.SelectedItem == null)
                {
                    throw new Exception("Debe seleccionar un cliente");
                }
                //validar repartidor
                if (CmbRepartidor.SelectedItem == null)
                {
                    throw new Exception("Debe seleccionar un repartidor");
                }

                //validar fecha del pedido
                DateTime fechaPedido = DtpFechaPedido.Value;

                bool ValidarFecha = PedidosN.ValidarFechaPedido(fechaPedido);
                if (!ValidarFecha)
                {
                    throw new Exception("La fecha del pedido no puede ser anterior a la fecha actual");

                }
                // Crear un nuevo objeto Pedidos con los datos validados
                
                return new Pedidos(0, fechaPedido, (Clientes)CmbCliente.SelectedItem, (Repartidores)CmbRepartidor.SelectedItem, TxtDireccion.Text.Trim());
            }
            catch (Exception ex)
            {
                // Muestra el mensaje de error personalizado 
                //mensaje de error sacado de: https://stackoverflow.com/questions/2109441/how-to-show-a-custom-error-or-warning-message-box-in-net-winforms
                MessageBox.Show("Error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        //metodo para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            CmbCliente.SelectedIndex = -1;
            CmbRepartidor.SelectedIndex = -1;
            TxtDireccion.Clear();
            DtpFechaPedido.Value = DateTime.Now;

        }

        private void FrmPedidos_Load(object sender, EventArgs e)
        {
            //cargar combobox 
            //idea sacada de la tutoria del tutor Johan Acosta :
            //https://www.youtube.com/watch?v=2IWiBqwDgKM
            List<Clientes> ArregloClientes = ClientesN.ObtenerClientes();
            CmbCliente.Items.Clear();
            CmbCliente.DisplayMember = "Nombre";
            CmbCliente.ValueMember = "Id";

            CmbCliente.DataSource = ArregloClientes;
            
            // Si hay elementos en el combobox, seleccionar el primero
            if (CmbCliente.Items.Count > 0)
            {
                CmbCliente.SelectedIndex = 0;
            }

            //llenar combobox Repartidores
            List<Repartidores> ArregloRepartidores = RepartidoresN.ObtenerRepartidores();
            CmbRepartidor.Items.Clear();
            CmbRepartidor.DisplayMember = "Nombre";
            CmbRepartidor.ValueMember = "Id";
            //recorrer el arreglo de repartidores y agregar al combobox
            for (int i = 0; i < ArregloRepartidores.Count; i++)
            {
                if (ArregloRepartidores[i] != null)
                {
                    CmbRepartidor.Items.Add(ArregloRepartidores[i]);
                }
            }
            // Si hay elementos en el combobox, seleccionar el primero
            if (CmbRepartidor.Items.Count > 0)
            {
                CmbRepartidor.SelectedIndex = 0;
            }
        }
    }
}


