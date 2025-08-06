using CapaAccesoADatos;
using CapaEntidades;

/*
   UNED SEGUNDO CUATRIMESTRE 2025
   PROYECTO 2:Agregar nuevas funcionalidades al software de la  empresa Entregas S.A
   Estudiante:Justin Paniagua Solano
   Cedula:305530632
   Fecha :27/7/2025
*/

namespace CapaLogicaNegocio
{
    public class DetallesPedidoN
    {
        private ArticulosN articulosN=new ArticulosN();

        // Metodo para agregar detalles del pedido
        public bool AgregarDetalles(int numeroPedido, Articulos articulo, int cantidad)
        {
            // Validar que el inventario sea suficiente
            if (articulo.Inventario < cantidad)
            {
                return false;// Inventario insuficiente
            }

            // Restar del inventario
            bool actualizado = articulosN.DescontarInventario(articulo.Id, cantidad);
            if (!actualizado)
            {
                return false;//Error al actualizar el inventario
            }

            // Calcular monto y registrar el detalle
            double monto = articulo.Valor * cantidad;
            DetallesPedido detalle = new DetallesPedido(numeroPedido, articulo, cantidad);
            detalle.Monto = monto;

            DetallesAD detallesAD = new DetallesAD();
            return detallesAD.AgregarDetalles(detalle);
        }

        // Metodo para validar si el detalle del pedido ya esta registrado
        public List<DetallesPedido> ObtenerDetallesPedidos()
        {
            DetallesAD detallesAD = new DetallesAD();
            return detallesAD.ObtenerDetallesPedidos();
        }

        // Metodo para obtener detalles de un pedido por su numero
        public List<DetallesPedido> ObtenerDetallesPorNumeroPedido(int numeroPedido)
        {
            DetallesAD detallesAD = new DetallesAD();
            return detallesAD.ObtenerDetallesPorNumeroPedido(numeroPedido);
        }
    }
}


