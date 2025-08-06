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
    public partial class FrmClientes : Form
    {
        //instancia de la clase ClientesN que contiene la logica de negocio
        private ClientesN ClientesN = new ClientesN();
        private FrmMenuServidor FrmMenu;//instancia del formulario del menu principal

        public FrmClientes(FrmMenuServidor FrmMenu)
        {
            InitializeComponent();
            this.FrmMenu = FrmMenu;
        }
        #region Botones de navegación(Menu ,guardar )
        //boton menu principal
        private void BttMenu_Click(object sender, EventArgs e)
        {
            FrmMenu.Show();
            this.Close();
        }
        //boton guardar
        private void BttGuardar_Click(object sender, EventArgs e)
        {
            //Llamado de la función de validación de campos
            Clientes clientes = ValidacionCampos();
            if (clientes == null)
                return; // Si la validación falla, se sale del método

            //llamado de la función para validar si el cliente ya existe
            bool Validar = ClientesN.ValidarIdCliente(clientes);
            if (Validar)
            {
                MessageBox.Show("Cliente Guardado correctamente");
                LimpiarCampos();
                CargarDatosDGV(); // Cargar los datos en el DataGridView después de guardar

            }
            else
            {
                MessageBox.Show("Error:ID debe de ser Unico");
            }
        }
        #endregion

        //Metodo para validar los campos ingresados por el usuario
        private Clientes ValidacionCampos()
        {
            try
            {
                // Validar identificación
                if (!int.TryParse(TxtIdentificacion.Text.Trim(), out int identificacion))
                    throw new Exception("La identificación del cliente debe de ser numeral...");

                // Validar nombre
                string Nombre = TxtNombre.Text.Trim();
                if (string.IsNullOrWhiteSpace(Nombre))
                    throw new Exception("Debe digitar el nombre...");

                //validar primer apellido
                string PrimerApellido = TxtPrimerApellido.Text.Trim();
                if (string.IsNullOrWhiteSpace(PrimerApellido))
                    throw new Exception("Debe digitar el primer Apellido...");

                // Validar segundo apellido
                string SegundoApellido = TxtSegundoApellido.Text.Trim();
                if (string.IsNullOrWhiteSpace(SegundoApellido))
                    throw new Exception("Debe digitar el Segundo Apellido...");


                DateTime fechaNacimiento = DtpFechaNacimiento.Value;

                // Validar combo activo
                if (CmbActivo.SelectedItem == null)
                    throw new Exception("Debe seleccionar si el cliente está activo o no.");

                bool activo = CmbActivo.SelectedItem.ToString() == "Si";

                // retornar un nuevo objeto Clientes con los datos validados
                return new Clientes(identificacion, Nombre, PrimerApellido, SegundoApellido, fechaNacimiento, activo);
            }
            catch (Exception ex)
            {
                // Muestra el mensaje de error personalizado 
                //mensaje de error sacado de: https://stackoverflow.com/questions/2109441/how-to-show-a-custom-error-or-warning-message-box-in-net-winforms
                MessageBox.Show("Error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        //funcion para limpiar los campos
        private void LimpiarCampos()
        {
            TxtIdentificacion.Clear();
            TxtNombre.Clear();
            TxtPrimerApellido.Clear();
            TxtSegundoApellido.Clear();
            DtpFechaNacimiento.Value = DateTime.Now;
            CmbActivo.SelectedIndex = 0;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            // Cargar el CmbActivo con los datos 
            CmbActivo.Items.Add("Si");
            CmbActivo.Items.Add("No");
            CmbActivo.SelectedIndex = 0;
            CargarColumasYFilas();//metodo para cargar las columnas y filas del DataGridView
            CargarDatosDGV();//metodo para cargar los datos del DataGridView
        }

        // Método para cargar las columnas y filas del DataGridView
        private void CargarColumasYFilas()
        {
            // Método para cargar las columnas y filas del DataGridView
            //Idea sacada de la tutoria de Johan Acosta:
            //https://www.youtube.com/watch?v=2IWiBqwDgKM

            DgvConsulta.DataSource = null;
            DgvConsulta.Rows.Clear();
            DgvConsulta.Columns.Clear();

            // Definicion de la columna y celda Identificacion
            DataGridViewColumn NuevaColumna = new DataGridViewColumn();
            DataGridViewCell NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Identificacion";
            NuevaColumna.Name = "Identificacion";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            // Definicion de la columna y celda Nombre
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Nombre";
            NuevaColumna.Name = "Nombre";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            // Definicion de la columna y celda Primer Apellido
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Primer Apellido";
            NuevaColumna.Name = "Primer Apellido";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            // Definicion de la columna y celda Segundo Apellido
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Segundo Apellido";
            NuevaColumna.Name = "Segundo Apellido";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            // Definicion de la columna y celda Fecha Nacimiento
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Fecha Nacimiento";
            NuevaColumna.Name = "Fecha Nacimiento";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            // Definicion de la columna y celda Activo
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Activo";
            NuevaColumna.Name = "Activo";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            // Agregar la columna al DataGridView
            DgvConsulta.Columns.Add(NuevaColumna);
        }
        // Método para cargar los datos del DataGridView
        private void CargarDatosDGV()
        {
            DgvConsulta.Rows.Clear();

            // Método para cargar los datos del DataGridView
            //Idea sacada de la tutoria de Johan Acosta:
            //https://www.youtube.com/watch?v=2IWiBqwDgKM
            List<Clientes> arregloClientes = ClientesN.ObtenerClientes();
            if (arregloClientes != null && arregloClientes.Count() > 0)
            {
                foreach (var arreglo in arregloClientes)
                {
                    if (arregloClientes != null)
                    {
                        DataGridViewRow Row = (DataGridViewRow)DgvConsulta.Rows[0].Clone();
                        Row.CreateCells(DgvConsulta);
                        Row.Cells[0].Value = arreglo.Identificacion;
                        Row.Cells[1].Value = arreglo.Nombre;
                        Row.Cells[2].Value = arreglo.PrimerApellido;
                        Row.Cells[3].Value = arreglo.SegundoApellido;
                        //Mostrar la fecha en formato corto
                        //idea sacada de :https://www.geeksforgeeks.org/c-sharp/datetime-toshortdatestring-method-in-c-sharp/
                        Row.Cells[4].Value = arreglo.FechaNacimiento.ToShortDateString();
                        Row.Cells[5].Value = arreglo.Activo;
                        DgvConsulta.Rows.Add(Row);
                    }
                }
            }

        }
    }
}
