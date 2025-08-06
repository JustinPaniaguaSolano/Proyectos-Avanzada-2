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
    public partial class FrmArticulos : Form
    {
        // Declaración de las instancias de las clases de la capa lógica de negocio
        private ArticulosN articulosN = new ArticulosN();
        private TiposArticulosN tiposArticulosN = new TiposArticulosN();
        private FrmMenuServidor FrmMenu;

        public FrmArticulos(FrmMenuServidor FrmMenu)
        {
            InitializeComponent();
            this.FrmMenu = FrmMenu;
        }
        #region Botones(menu ,guardar)
        //boton para regresar al menu principal
        private void BttMenu_Click(object sender, EventArgs e)
        {
            FrmMenu.Show();
            this.Close();
        }
        //boton para guardar el articulo
        private void BttGuardar_Click(object sender, EventArgs e)
        {
            // Validación de los campos de entrada
            Articulos Validacion =ValidacionCampos();
            if (Validacion == null)
            {
                return;// Si la validación falla, se sale del método
            }

            // Si la validación es exitosa, se procede a guardar el artículo
            bool Validar = articulosN.ValidarArticulo(Validacion);

            if (Validar)
            {
                MessageBox.Show("Tipo de artículo agregado correctamente");
                LimpiarCampos();//llamado de la funcion para limpiar los campos
                CargarDatosDGV();//llamado de la funcion para cargar los datos al DataGridView
            }
            // Si el artículo ya existe, se muestra un mensaje de error
            else
            {
                MessageBox.Show("Error:ID debe de ser Unico");
            }
        }
#endregion
#region Validaciones

        //Metodo para validar los campos ingresados por el usuario
        private Articulos ValidacionCampos()
        {
            try
            {
                // Validar ID
                //idea de validacion sacada de: https://stackoverflow.com/questions/1752499/c-sharp-testing-to-see-if-a-string-is-an-integer
                if (!int.TryParse(TxtID.Text.Trim(), out int id))
                    throw new Exception("ID Incorrecto (El ID del articulo debe de ser Numeral)...");

                // Validar nombre
                string nombre = TxtNombre.Text.Trim();
                if (string.IsNullOrWhiteSpace(nombre))
                    throw new Exception("Debe de digitar un nombre para el articulo...");

                // Validar valor
                if (!double.TryParse(TxtValor.Text.Trim(), out double valor))
                    throw new Exception("El valor del articulo debe de ser numeral...");

                // Validar inventario
                if (!int.TryParse(TxtInventario.Text.Trim(), out int inventario))
                    throw new Exception("El inventario del articulo debe de ser numeral...");

                // Validar tipo de artículo
                if (CmbTipoArticulo.SelectedItem == null)
                    throw new Exception("Debe seleccionar un tipo de artículo para registrar el articulo...");

                TiposArticulos tipo = (TiposArticulos)CmbTipoArticulo.SelectedItem;

                // Validar estado activo
                if (CmbActivo.SelectedItem == null)
                    throw new Exception("Debe seleccionar si el artículo está activo o no...");

                bool activo = CmbActivo.SelectedItem.ToString() == "Si";

                // Se retorna el nuevo objeto Articulos con los datos validados
                return new Articulos(id, nombre, tipo, valor, inventario, activo);
            }
            catch (Exception ex)
            {
                // Muestra el mensaje de error personalizado 
                //mensaje de error sacado de: https://stackoverflow.com/questions/2109441/how-to-show-a-custom-error-or-warning-message-box-in-net-winforms
                MessageBox.Show("Error: " + ex.Message, "Error Critico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
#endregion
        private void FrmArticulos_Load(object sender, EventArgs e)
        {
            //cargar combobox 
            //idea sacada de la tutoria del tutor Johan Acosta :
            //https://www.youtube.com/watch?v=2IWiBqwDgKM

            List<TiposArticulos> ArregloTiposArticulos = tiposArticulosN.ObtenerTiposArticulos();//se obtienen los TiposArticulos
            CmbTipoArticulo.Items.Clear();
            CmbTipoArticulo.DisplayMember = "Nombre";
            CmbTipoArticulo.ValueMember = "Id";

            //Se recorre el arreglo
            for (int i = 0;i< ArregloTiposArticulos.Count; i++)
            {
                if (ArregloTiposArticulos[i] != null)
                {
                    CmbTipoArticulo.Items.Add(ArregloTiposArticulos[i]);//se agregan los datos
                    
                }
            }
            //Se selecciona por defecto el Index 0
            if (CmbTipoArticulo.Items.Count > 0)
            {
                CmbTipoArticulo.SelectedIndex = 0; 
            }

           //combobox de activo
            CmbActivo.Items.Add("Si");
            CmbActivo.Items.Add("No");
            CmbActivo.SelectedIndex = 0;
            CargarColumasYFilas();//metodo para cargar las columnas y filas del DataGridView
            CargarDatosDGV();//metodo para cargar los datos del DataGridView
        }
        private void CargarColumasYFilas()
        {
            // Método para cargar las columnas y filas del DataGridView
            //Idea sacada de la tutoria de Johan Acosta:
            //https://www.youtube.com/watch?v=2IWiBqwDgKM
            ArticulosN articulosN = new ArticulosN();
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
            NuevaColumna.HeaderText = "Nombre";
            NuevaColumna.Name = "Nombre";
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
            NuevaColumna.HeaderText = "Valor";
            NuevaColumna.Name = "Valor";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            //definicion de la columna y celda Inventario
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Inventario";
            NuevaColumna.Name = "Inventario";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            //definicion de la columna y celda Activo
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
        //metodo para cargar los datos a DGV
        private void CargarDatosDGV()
        {
            DgvConsulta.Rows.Clear();
            // Método para cargar los datos del DataGridView
            //Idea sacada de la tutoria de Johan Acosta:
            //https://www.youtube.com/watch?v=2IWiBqwDgKM

            List<Articulos> arregloArticulos = articulosN.ObtenerArticulos();

            if (arregloArticulos != null && arregloArticulos.Count() > 0)
            {
                foreach (var arregloArticulo in arregloArticulos)
                {
                    if (arregloArticulos != null)
                    {
                        DataGridViewRow Row = (DataGridViewRow)DgvConsulta.Rows[0].Clone();
                        Row.CreateCells(DgvConsulta);
                        Row.Cells[0].Value = arregloArticulo.Id;
                        Row.Cells[1].Value = arregloArticulo.Nombre;
                        Row.Cells[2].Value = arregloArticulo.TiposArticulos.Nombre;
                        Row.Cells[3].Value = arregloArticulo.Valor;
                        Row.Cells[4].Value = arregloArticulo.Inventario;
                        Row.Cells[5].Value = arregloArticulo.Activo;

                        DgvConsulta.Rows.Add(Row);
                    }
                }
            }
        }
        
        //metodo para limpiar los campos
        private void LimpiarCampos()
        {
            TxtID.Clear();
            TxtNombre.Clear();
            TxtValor.Clear();
            TxtInventario.Clear();
            CmbTipoArticulo.SelectedIndex = 0;
            CmbActivo.SelectedIndex = 0;
        }
    }
}
