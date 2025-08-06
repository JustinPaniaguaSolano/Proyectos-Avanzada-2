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
    public partial class FrmRepartidor : Form
    {
        private RepartidoresN repartidoresN = new RepartidoresN();
        private FrmMenuServidor FrmMenu;

        public FrmRepartidor(FrmMenuServidor FrmMenu)
        {
            InitializeComponent();
            this.FrmMenu = FrmMenu;
        }

        //Boton menu 
        private void BttMenu_Click(object sender, EventArgs e)
        {
            FrmMenu.Show();
            this.Close();
        }
        //boton guardar
        private void BttGuardar_Click(object sender, EventArgs e)
        {
            // Llama al método ValidarCampos para validar los campos del formulario
            Repartidores repartidores = ValidarCampos();
            // Si la validación falla, repartidores será null
            if (repartidores == null)
            {
                return; // Si la validación falla, se sale del método
            }

            // Llama al método ValidarIdRepartidor para verificar si el repartidor ya está registrado   
            bool Validar = repartidoresN.ValidarIdRepartidor(repartidores);
            //Si se guarda correctamente, Validar será true
            if (Validar)
            {
                MessageBox.Show("Repartidor Guardado correctamente");
                LimpiarCampos();
                CargarDatosAlDGV(); // Cargar los datos en el DataGridView después de guardar
            }
            //En caso contrario, se muestra un mensaje de error
            else
            {
                MessageBox.Show("Error:ID debe de ser Unico");
            }
        }
        // Método para validar los campos ingresados por el usuario
        private Repartidores ValidarCampos()
        {
            try
            {
                // Validar número de identificación
                if (!int.TryParse(TxtIdentificacion.Text.Trim(), out int id))
                {
                    throw new Exception("El numero de identificacion debe de ser numeral");
                }

                //validar nombre repartidor
                string nombre = TxtNombre.Text.Trim();
                if (string.IsNullOrEmpty(nombre))
                {
                    throw new Exception("El nombre del repartidor no puede estar vacio...");
                }

                //validar primer apellido
                string PriApellido = TxtPriApelli.Text.Trim();
                if (string.IsNullOrEmpty(PriApellido))
                {
                    throw new Exception("El primer apellido del repartidor no puede estar vacio...");
                }

                //validar segundo apellido
                string SegApellido = TxtSegApellido.Text.Trim();
                if (string.IsNullOrEmpty(SegApellido))
                {
                    throw new Exception("El segundo apellido del repartidor no puede estar vacio....");
                }
                //validar que sea mayor de edad
                DateTime fechaNaci = DtpFechNaci.Value;
                if (!repartidoresN.ValidarEdad(fechaNaci))
                {
                    throw new Exception("El repartidor debe de ser mayor de edad");
                }
                //validar fecha de contratacion no sea futura
                DateTime fechaContr = DtpFecCont.Value;
                if (!repartidoresN.ValidarFechaContratacion(fechaContr))
                {
                    throw new Exception("La fecha de contratacion no puede ser futura");
                }

                bool activo = CmbActivo.SelectedItem.ToString() == "Si";

                // Crear un nuevo objeto Repartidores con los datos validados
                return new Repartidores(id, nombre, PriApellido, SegApellido, fechaNaci, fechaContr, activo);
            }

            catch (Exception ex)
            {
                // Muestra el mensaje de error personalizado 
                //mensaje de error sacado de: https://stackoverflow.com/questions/2109441/how-to-show-a-custom-error-or-warning-message-box-in-net-winforms
                MessageBox.Show("Error: " + ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Método para limpiar los campos del formulario
        private void LimpiarCampos()
        {
            TxtIdentificacion.Clear();
            TxtNombre.Clear();
            TxtPriApelli.Clear();
            TxtSegApellido.Clear();
            DtpFechNaci.Value = DateTime.Now;
            DtpFecCont.Value = DateTime.Now;
            CmbActivo.SelectedIndex = 0;
        }

        private void FrmRepartidor_Load(object sender, EventArgs e)
        {
            // Inicializa el ComboBox CmbActivo con las opciones "Si" y "No"
            CmbActivo.Items.Add("Si");
            CmbActivo.Items.Add("No");
            CmbActivo.SelectedIndex = 0;
            CargarColumnasYFilasDGV(); // Cargar las columnas y filas del DataGridView
            CargarDatosAlDGV();// Cargar los datos al DataGridView
        }

        // Método para cargar las columnas y filas del DataGridView
        private void CargarColumnasYFilasDGV()
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

            // Definicion de la columna y celda Fecha Contratacion
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Fecha Contratacion";
            NuevaColumna.Name = "Fecha Contratacion";
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

            DgvConsulta.Columns.Add(NuevaColumna);// Agregar la columna al DataGridView
        }
        //metodo para cargar los datos al DataGridView
        private void CargarDatosAlDGV()
        {
            DgvConsulta.Rows.Clear();

            // Método para cargar lo datos al  DataGridView
            //Idea sacada de la tutoria de Johan Acosta:
            //https://www.youtube.com/watch?v=2IWiBqwDgKM
            List<Repartidores> arregloRepartidores = repartidoresN.ObtenerRepartidores();

            if (arregloRepartidores != null && arregloRepartidores.Count() > 0)
            {
                foreach (var arregloRepartidor in arregloRepartidores)
                {
                    if (arregloRepartidores != null)
                    {
                        DataGridViewRow Row = (DataGridViewRow)DgvConsulta.Rows[0].Clone();
                        Row.CreateCells(DgvConsulta);
                        Row.Cells[0].Value = arregloRepartidor.Identificacion;
                        Row.Cells[1].Value = arregloRepartidor.Nombre;
                        Row.Cells[2].Value = arregloRepartidor.PrimerApellido;
                        Row.Cells[3].Value = arregloRepartidor.SegundoApellido;
                        //Mostrar la fecha en formato corto
                        //idea sacada de :https://www.geeksforgeeks.org/c-sharp/datetime-toshortdatestring-method-in-c-sharp/
                        Row.Cells[4].Value = arregloRepartidor.FechaNacimiento.ToShortDateString();
                        Row.Cells[5].Value = arregloRepartidor.FechaContractacion.ToShortDateString();
                        Row.Cells[6].Value = arregloRepartidor.Activo;

                        DgvConsulta.Rows.Add(Row);

                    }
                }
            }
        }
    }
}
