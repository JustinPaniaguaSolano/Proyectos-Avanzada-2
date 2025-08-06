using CapaEntidades;
using ClienteCapaPresentacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
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
        private Clientes clienteSesion;
        private FrmMenuCliente FrmMenu;


        public FrmPedidos(Clientes cliente, FrmMenuCliente FrmMenu)
        {
            InitializeComponent();
            this.clienteSesion = cliente;
            this.FrmMenu = FrmMenu;

            //Configuracion de las labels con los datos del cliente
            LblCliente.Text = $"{clienteSesion.Nombre} {clienteSesion.PrimerApellido} {clienteSesion.SegundoApellido}";
            LblCliente.ForeColor = Color.Green;
            LblIdentificacion.Text = $" {clienteSesion.Identificacion}";
            LblIdentificacion.ForeColor = Color.Green;
        }

        private List<DetallesPedido> listaDetalles = new List<DetallesPedido>();// Lista para almacenar los detalles del pedido

        //Boton Menu
        private void BttMenu_Click(object sender, EventArgs e)
        {
            FrmMenu.Show();
            this.Close();
        }

        //Boton Guardar
        private void BttGuardar_Click(object sender, EventArgs e)
        {

            if (listaDetalles.Count == 0)
            {
                MessageBox.Show("Debe de darle primero al boton de mostrar Detalles");
                return;
            }

            Pedidos pedido = new Pedidos();
            pedido.FechaPedido = DtpFechaPedido.Value;
            pedido.clientes = clienteSesion;

            pedido.repartidores = (Repartidores)CmbRepartidor.SelectedItem;
            pedido.Direccion = TxtDireccion.Text.Trim();

            if (string.IsNullOrWhiteSpace(pedido.Direccion))
            {
                MessageBox.Show("Debe ingresar una dirección de entrega.");
                return;
            }

            bool exito = ClienteTCP.EnviarPedidoConDetalles(pedido, listaDetalles);

            if (exito)
            {
                MessageBox.Show("Pedido realizado correctamente.");
                listaDetalles.Clear();
                ActualizarGridDetalles();
            }
            else
            {
                MessageBox.Show("Error al realizar el pedido.");
            }
        }
        private void ActualizarGridDetalles()
        {
            DvgDetallesArticulos.Rows.Clear();
            DvgDetallesArticulos.Columns.Clear();

            DvgDetallesArticulos.Columns.Add("Id", "ID");
            DvgDetallesArticulos.Columns.Add("Cantidad", "Cantidad");
            DvgDetallesArticulos.Columns.Add("Monto", "Monto");

           foreach (var detalle in listaDetalles)
            {
                DvgDetallesArticulos.Rows.Add(detalle.IDArticulo, detalle.Cantidad, detalle.Monto);
            }
        }
        private void FrmPedidos_Load(object sender, EventArgs e)
        {

            // Cargar repartidores
            List<Repartidores> listaRepartidores = ClienteTCP.ObtenerRepartidores();
            CmbRepartidor.DataSource = listaRepartidores;
            CmbRepartidor.DisplayMember = "Nombre";
            CmbRepartidor.ValueMember = "Identificacion";

            try
            {
                // Obtener artículos activos desde el servidor
                List<Articulos> articulosActivos = ClienteTCP.ObtenerArticulosActivos();
                if (articulosActivos == null || articulosActivos.Count == 0)
                {
                    MessageBox.Show("No hay artículos activos disponibles.");
                    return;
                }
                // Asignar la lista de artículos al ComboBox
                CmbArticulos.DataSource = articulosActivos;
                CmbArticulos.DisplayMember = "Nombre";
                CmbArticulos.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar artículos: " + ex.Message);
            }
        }

        //Boton mostrar detalles del articulo seleccionado
        private void BttAgregarArticulo_Click(object sender, EventArgs e)
        {
            //Validar que se haya seleccionado un artículo 
            if (CmbArticulos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un artículo.");
                return;
            }
            // Validar que se haya ingresado una cantidad válida
            if (!int.TryParse(TxtCantidad.Text.Trim(), out int cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Ingrese una cantidad válida mayor que 0.");
                return;
            }

            Articulos articuloSeleccionado = (Articulos)CmbArticulos.SelectedItem;
            // Validar que la cantidad no supere el inventario del artículo seleccionado
            if (cantidad > articuloSeleccionado.Inventario)
            {
                MessageBox.Show("Cantidad supera el inventario disponible.");
                return;
            }

            // Buscar el detalle
            DetallesPedido detalleExistente = null;
            foreach (var detalle in listaDetalles)
            {
                if (detalle.IDArticulo == articuloSeleccionado.Id)
                {
                    detalleExistente = detalle;
                    break;
                }
            }

            if (detalleExistente != null)
            {
                if (detalleExistente.Cantidad + cantidad > articuloSeleccionado.Inventario)
                {
                    MessageBox.Show("Cantidad total supera el inventario disponible.");
                    return;
                }

                detalleExistente.Cantidad += cantidad;
                detalleExistente.Monto = detalleExistente.Cantidad * articuloSeleccionado.Valor;
            }
            else
            {
                listaDetalles.Add(new DetallesPedido
                {
                    IDArticulo = articuloSeleccionado.Id,
                    Cantidad = cantidad,
                    Monto = cantidad * articuloSeleccionado.Valor
                });
            }
            ActualizarGridDetalles();
        }
    }
}



