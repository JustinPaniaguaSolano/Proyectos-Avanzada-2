using CapaEntidades;
using CapaLogicaNegocio;
using ServidorCapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CapaPresentacion
/*
   UNED SEGUNDO CUATRIMESTRE 2025
   PROYECTO 2:Agregar nuevas funcionalidades al software de la  empresa Entregas S.A
   Estudiante:Justin Paniagua Solano
   Cedula:305530632
   Fecha :27/7/2025
*/
{
    public partial class FrmTiposArticulos : Form
    {
        private TiposArticulosN tiposArticulosN = new TiposArticulosN();
        private FrmMenuServidor FrmMenu;

        public FrmTiposArticulos(FrmMenuServidor FrmMenu)
        {
            InitializeComponent();
            this.FrmMenu = FrmMenu;
        }
        //boton guardar
        private void BttGuardar_Click(object sender, EventArgs e)
        {
            // Llama al método ValidarCampos para validar los campos del formulario
            TiposArticulos tiposArticulos = ValidarCampos();
            if (tiposArticulos == null)
            {
                return;
            }
            //validar el id del tipo de articulo
            bool Validar = tiposArticulosN.ValidarTipoArticulo(tiposArticulos);

            if (Validar)
            {
                MessageBox.Show("Tipo de artículo agregado correctamente");
                LimpiarCampos();
                CargarDatosDGV();

            }
            else
            {
                MessageBox.Show("Error:ID debe de ser Unico");
            }
        }
        // Método para validar los campos ingresados por el usuario
        private TiposArticulos ValidarCampos()
        {
            try
            {
                // Validar ID
                if (!int.TryParse(TxtID.Text.Trim(), out int id))
                {
                    throw new Exception("El ID del tipos articulo debe de ser numeral");
                }

                // Validar Nombre
                string nombre = TxtNombre.Text.Trim();
                if (string.IsNullOrEmpty(nombre))
                {
                    throw new Exception("El Nombre del tipo de articulo es obligatorio");
                }

                // Validar Descripción
                string descripcion = TxtDescripcion.Text.Trim();
                if (string.IsNullOrEmpty(descripcion))
                {
                    throw new Exception("La Descripción  del tipo de articulo es obligatoria");
                }
                // Crea una nueva instancia de TiposArticulos con los valores validados
                return new TiposArticulos(id, nombre, descripcion);
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
            TxtID.Clear();
            TxtNombre.Clear();
            TxtDescripcion.Clear();
        }

        //boton menu
        private void BttMenu_Click(object sender, EventArgs e)
        {
            FrmMenu.Show();
            this.Close();
        }

        private void FrmTiposArticulos_Load(object sender, EventArgs e)
        {
            CargarColumnasYFilasDGV(); // Cargar las columnas y filas del DataGridView
            CargarDatosDGV(); // Cargar los datos al DataGridView



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

            // Definicion de la columna y celda ID
            DataGridViewColumn NuevaColumna = new DataGridViewColumn();
            DataGridViewCell NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "ID";
            NuevaColumna.Name = "ID";
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

            // Definicion de la columna y celda Descripcion
            DgvConsulta.Columns.Add(NuevaColumna);
            NuevaColumna = new DataGridViewColumn();
            NuevaCelda = new DataGridViewTextBoxCell();

            NuevaColumna.CellTemplate = NuevaCelda;
            NuevaColumna.HeaderText = "Descripcion";
            NuevaColumna.Name = "Descripcion";
            NuevaColumna.Visible = true;
            NuevaColumna.Width = 100;

            DgvConsulta.Columns.Add(NuevaColumna);// Añadir la columna  al DataGridView
        }
        // Método para cargar los datos del DataGridView
        private void CargarDatosDGV()
        {
            DgvConsulta.Rows.Clear();

            // Método para cargar los datos del DataGridView
            //Idea sacada de la tutoria de Johan Acosta:
            //https://www.youtube.com/watch?v=2IWiBqwDgKM

            List<TiposArticulos> arregloTiposArticulos = tiposArticulosN.ObtenerTiposArticulos();

            if (arregloTiposArticulos != null && arregloTiposArticulos.Count() > 0)
            {
                foreach (var arregloTiposArticulo in arregloTiposArticulos)
                {
                    if (arregloTiposArticulo != null)
                    {
                        DataGridViewRow Row = (DataGridViewRow)DgvConsulta.Rows[0].Clone();
                        Row.CreateCells(DgvConsulta);
                        Row.Cells[0].Value = arregloTiposArticulo.Id;
                        Row.Cells[1].Value = arregloTiposArticulo.Nombre;
                        Row.Cells[2].Value = arregloTiposArticulo.Descripcion;

                        DgvConsulta.Rows.Add(Row);
                    }
                }
            }
        }
    }
    }

