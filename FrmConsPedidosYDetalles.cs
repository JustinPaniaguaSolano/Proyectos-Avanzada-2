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
    public partial class FrmConsPedidosYDetalles : Form
    {
        PedidosN pedidos = new PedidosN();
        DetallesPedidoN detallesPedidoN = new DetallesPedidoN();
        private FrmMenuServidor FrmMenu;

        public FrmConsPedidosYDetalles(FrmMenuServidor FrmMenu)
        {
            InitializeComponent();
            this.FrmMenu = FrmMenu;
        }

        private void FrmConsPedidosYDetalles_Load(object sender, EventArgs e)
        {
            //seleccionar una fila completa al hacer click en ella
            //idea sacada de :
            //https://learn.microsoft.com/es-es/dotnet/desktop/winforms/controls/selection-modes-in-the-windows-forms-datagridview-control
            DgvConsultaPedidos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvConsultaPedidos.MultiSelect = false;

            CargarColumnasYFilasPedidos();//llamado de la funcion para cargar las columnas y filas del DataGridView de pedidos
            CargarDatosDGVPedidos();//llamadado de la funcion para cargar los datos al DataGridView de pedidos
            CargarColumnasYFilasDetalles();//llamado de la funcion para cargar las columnas y filas del DataGridView de detalles de pedidos
        }
        //metodo para cargar las columnas y filas del DataGridView de pedidos
        private void CargarColumnasYFilasPedidos()
        {
            // Método para cargar las columnas y filas del DataGridView
            //Idea sacada de la tutoria de Johan Acosta:
            //https://www.youtube.com/watch?v=2IWiBqwDgKM
            DgvConsultaPedidos.DataSource = null;
            DgvConsultaPedidos.Rows.Clear();
            DgvConsultaPedidos.Columns.Clear();

            // Definicion de las columnas y celdas Nuevo Pedido del DataGridView de pedidos
            DataGridViewColumn NuevaColumna = new DataGridViewColumn();
            DataGridViewCell NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Numero Pedido";
            NuevaColumna.Name = "Numero Pedido";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            //Definicion de la columna y celda Fecha Pedido
            DgvConsultaPedidos.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

        
            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Fecha Pedido";
            NuevaColumna.Name = "Fecha Pedido";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;
            

            //Definicion de la columna y celda Identificacion Cliente
            DgvConsultaPedidos.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();


            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Identificacion Cliente";
            NuevaColumna.Name = "Identificacion Cliente";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            //Definicion de la columna y celda Nombre Cliente
            DgvConsultaPedidos.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Nombre Cliente";
            NuevaColumna.Name = "Nombre Cliente";
            NuevaColumna.Visible = true;

            // Definicion de la columna y celda Primer Apellido Cliente
            NuevaColumna.Width = 100;
            DgvConsultaPedidos.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Apellido Cliente";
            NuevaColumna.Name = "Apellido Cliente";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            //definicion de la columna y celda Segundo Apellido Cliente
            DgvConsultaPedidos.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Segundo Apellido Cliente";
            NuevaColumna.Name = "Segundo Apellido Cliente";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            //definicion de la columna y celda Identificacion Repartidor
            DgvConsultaPedidos.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Identificacion Repartidor";
            NuevaColumna.Name = "Identificacion Repartidor";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            //definicion de la columna y celda Nombre Repartidor
            DgvConsultaPedidos.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Nombre Repartidor";
            NuevaColumna.Name = "Nombre Repartidor";
            NuevaColumna.Visible = true;

            // Definicion de la columna y celda Primer Apellido Repartidor
            NuevaColumna.Width = 100;
            DgvConsultaPedidos.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Apellido Repartidor";
            NuevaColumna.Name = "Apellido Repartidor";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            //definicion de la columna y celda Segundo Apellido Repartidor
            DgvConsultaPedidos.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Segundo Apellido Repartidor";
            NuevaColumna.Name = "Segundo Apellido Repartidor";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            //definicion de la columna y celda Direccion
            DgvConsultaPedidos.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Direccion";
            NuevaColumna.Name = "Direccion";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            // Agregar la columna al DataGridView
            DgvConsultaPedidos.Columns.Add(NuevaColumna);
        }

        //metodo para cargar los datos al DataGridView de pedidos
        private void CargarDatosDGVPedidos()
        {
            // Método para cargar los datos al DataGridView
            //Idea sacada de la tutoria de Johan Acosta:
            //https://www.youtube.com/watch?v=2IWiBqwDgKM

            List<Pedidos> arregloPedidos = pedidos.ObtenerPedidos();

            if (arregloPedidos != null && arregloPedidos.Count() > 0)
            {
                foreach (var arreglo in arregloPedidos)
                {
                    if (arregloPedidos != null)
                    {
                        DataGridViewRow Row = new DataGridViewRow();
                        //datos pedido
                        Row.CreateCells(DgvConsultaPedidos);
                        Row.Cells[0].Value = arreglo.NumeroPedido;
                        //Mostrar la fecha en formato corto
                        //idea sacada de :https://www.geeksforgeeks.org/c-sharp/datetime-toshortdatestring-method-in-c-sharp/
                        Row.Cells[1].Value = arreglo.FechaPedido.ToShortDateString();

                        //datos cliente 
                        Row.Cells[2].Value = arreglo.clientes.Identificacion;
                        Row.Cells[3].Value = arreglo.clientes.Nombre;
                        Row.Cells[4].Value = arreglo.clientes.PrimerApellido;
                        Row.Cells[5].Value = arreglo.clientes.SegundoApellido;

                        //datos repartidor
                        Row.Cells[6].Value = arreglo.repartidores.Identificacion;
                        Row.Cells[7].Value = arreglo.repartidores.Nombre;
                        Row.Cells[8].Value = arreglo.repartidores.PrimerApellido;
                        Row.Cells[9].Value = arreglo.repartidores.SegundoApellido;

                        Row.Cells[10].Value = arreglo.Direccion;

                        DgvConsultaPedidos.Rows.Add(Row);
                    }
                }
            }
        }
        //metodo para cargar las columnas y filas del DataGridView de detalles de pedidos
        private void CargarColumnasYFilasDetalles()
        { 
            // Método para cargar las columnas y filas del DataGridView
            //Idea sacada de la tutoria de Johan Acosta:
            //https://www.youtube.com/watch?v=2IWiBqwDgKM
            DgvDetallesPedidos.DataSource = null;
            DgvDetallesPedidos.Rows.Clear();
            DgvDetallesPedidos.Columns.Clear();

            //definicion de las columnas y celdas de ID articulo
            DataGridViewColumn NuevaColumna = new DataGridViewColumn();
            DataGridViewCell NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "ID Articulo";
            NuevaColumna.Name = "ID Articulo";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            //definicion de la columna y celda Nombre Articulo
            DgvDetallesPedidos.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Nombre Articulo";
            NuevaColumna.Name = "Nombre Articulo";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            //definicion de la columna y celda Tipo Articulo
            DgvDetallesPedidos.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Tipo Articulo";
            NuevaColumna.Name = "Tipo Articulo";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            //definicion de la columna y celda Cantidad
            DgvDetallesPedidos.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Cantidad";
            NuevaColumna.Name = "Cantidad";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            //definicion de la columna y celda Monto
            DgvDetallesPedidos.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Monto";
            NuevaColumna.Name = "Monto";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;


            DgvDetallesPedidos.Columns.Add(NuevaColumna);// Agregar la columna al DataGridView
        }

        //boton para regresar al menu principal
        private void BttMenu_Click(object sender, EventArgs e)
        {
            FrmMenu.Show();
            this.Close();
        }

        //boton para mostrar los detalles del pedido seleccionado
        private void BttMostrarDetalles_Click(object sender, EventArgs e)
        {
            //validar que se haya seleccionado un pedido
            if (DgvConsultaPedidos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor seleccione un pedido.");
                return;
            }

            //obtener el numero del pedido seleccionado y convertirlo a entero
            //idea sacada de:
            //https://stackoverflow.com/questions/7657137/datagridview-full-row-selection-but-get-single-cell-value
            int numero = Convert.ToInt32(DgvConsultaPedidos.SelectedRows[0].Cells["Numero Pedido"].Value);

            //obtener todos los detalles de pedidos
            List<DetallesPedido> TodoslosPedidos;
            if (detallesPedidoN.ObtenerDetallesPedidos() != null)
            {
                TodoslosPedidos = detallesPedidoN.ObtenerDetallesPedidos();
            }
            else
            {
                TodoslosPedidos = new List<DetallesPedido>();
            }

            List<DetallesPedido> ListaPedidos = new List<DetallesPedido>();//lista para almacenar los detalles del pedido seleccionado
             //se recorre la lista para encontrar los detalles del pedido seleccionado
            for (int i=0;i<TodoslosPedidos.Count;i++)
            {
                if (TodoslosPedidos[i] != null && TodoslosPedidos[i].NumeroPedido == numero) ;//verifica si el pedido es el seleccionado
                {
                    ListaPedidos.Add(TodoslosPedidos[i]);//agrega el pedido a la lista
                }
            }
            //si no tiene detalles
            if(ListaPedidos.Count==0)
            {
                MessageBox.Show($"No hay detalles para el pedido {numero}.");
                DgvDetallesPedidos.Rows.Clear();
                return;
            }

            //Llamadar al metodo para mostrar los detalles del pedido
            MostrarDetalles(numero);
        }

        //Metodo para mostrar los detalles del pedido seleccionado
        private void MostrarDetalles(int numero)
        {
            DgvDetallesPedidos.Rows.Clear();

            DetallesPedido detallesPedido = new DetallesPedido();
            List<DetallesPedido> TodosLosDetalles= detallesPedidoN.ObtenerDetallesPedidos();//obtener todos los detalles de pedidos
            List<DetallesPedido> ListaFiltrada = new List<DetallesPedido>();//Lista para almacenar los detalles del pedido seleccionado
             
            //recorrer todos los detalles de pedidos
            if (TodosLosDetalles != null)
            {
                for (int i=0;i<TodosLosDetalles.Count;i++)
                {
                    if (TodosLosDetalles[i] !=null && TodosLosDetalles[i].NumeroPedido==numero)//verificar si el detalle pertenece al pedido seleccionado
                    {
                        ListaFiltrada.Add(TodosLosDetalles[i]);//se agrega a la lista filtrada
                    }
                }
            }

            ArticulosN artN = new ArticulosN();//instancia de la clase ArticulosN para buscar los articulos por su id
            
            //recorrer la lista filtrada y agregar los detalles al DataGridView
            for (int i=0;i<ListaFiltrada.Count;i++)
            {
                var DetalesP= ListaFiltrada[i];
                if(DetalesP !=null)
                {
                    Articulos artic = artN.BuscarTipoArticulo(DetalesP.IDArticulo);
                    var fila = new DataGridViewRow();
                    fila.CreateCells(DgvDetallesPedidos);
                    fila.Cells[0].Value = artic.Id.ToString();
                    fila.Cells[1].Value = artic.Nombre;
                    fila.Cells[2].Value = artic.TiposArticulos?.Nombre;
                    fila.Cells[3].Value = DetalesP.Cantidad;
                    fila.Cells[4].Value = DetalesP.Monto;
                    DgvDetallesPedidos.Rows.Add(fila);
                }
            }
        }
    }
}
