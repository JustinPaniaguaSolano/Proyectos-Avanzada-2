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
    public class PedidosN
    {
        //Metodo para agregar un pedido y obtener su ID
        public int AgregarPedidoYObtenerId(Pedidos pedido)
        {
            PedidosAD pedidosAD = new PedidosAD();
            return pedidosAD.AgregarPedidoYObtenerId(pedido);
        }

        // Metodo para obtener los pedidos registrados
        public List<Pedidos> ObtenerPedidos()
        {
            PedidosAD PedidosAD = new PedidosAD();
            return PedidosAD.ObtenerPedidos();
        }

        // Metodo para validar la fecha de entrega del pedido
        public bool ValidarFechaPedido(DateTime fechaEntrega)
        {
            DateTime hoy = DateTime.Now;
            return fechaEntrega > hoy;
        }
        
        // Metodo para obtener los pedidos por cliente teniendo en cuenta su identificacion
        public static List<Pedidos> ObtenerPedidosPorCliente(string identificacion)
        {
            PedidosAD pedidosAD = new PedidosAD();

            List<Pedidos> Pedidos = pedidosAD.ObtenerPedidos();
            List<Pedidos> pedidosDelCliente = new List<Pedidos>();

            foreach (Pedidos pedido in Pedidos)
            {
                if (pedido.clientes.Identificacion.ToString() == identificacion)
                {
                    pedidosDelCliente.Add(pedido);
                }
            }
            return pedidosDelCliente;
        }

        // Metodo para obtener un pedido por su ID
        public static Pedidos? ObtenerPedidoPorId(int id)
        {
            PedidosAD pedidosAD = new PedidosAD();
            List<Pedidos> TodosPedidos = pedidosAD.ObtenerPedidos();

            foreach (Pedidos pedido in TodosPedidos)
            {
                if (pedido.NumeroPedido == id)
                {
                    return pedido; // Retorna el primer pedido que coincida con el ID
                }
            }

            return null; // Si no se encuentra ningún pedido con ese ID
        }

        // Metodo para agregar un pedido con sus detalles 
        public bool AgregarPedido(Pedidos pedido, List<DetallesPedido> detalles)
        {
            ClientesN clientesN = new ClientesN();
            List<Clientes> Clientes = clientesN.ObtenerClientes();
            Clientes clienteEncontrado = null;
            //Se verifica si el cliente existe en la lista de clientes
            foreach (var cliente in Clientes)
            {
                if (cliente.Identificacion == pedido.clientes.Identificacion)
                {
                    clienteEncontrado = cliente;
                    break;// Se sale del bucle si se encuentra el cliente
                }
            }

            if (clienteEncontrado == null)
                return false; // Cliente no existe

            int idPedido = AgregarPedidoYObtenerId(pedido);// Se agrega el pedido y se obtiene su ID
            if (idPedido <= 0)
                return false; // Error insertando pedido

            ArticulosN articulosN = new ArticulosN();
            List<Articulos> Articulos = articulosN.ObtenerArticulos();
            // Se verifica si los detalles del pedido son válidos
            foreach (var detalle in detalles)
            {
                detalle.NumeroPedido = idPedido;

                Articulos articuloEncontrado = null;
                // Se busca el artículo en la lista de artículos
                foreach (var articulo in Articulos)
                {
                    if (articulo.Id == detalle.IDArticulo)
                    {
                        articuloEncontrado = articulo;
                        break;
                    }
                }
                //Validaciones de los detalles del pedido
                if (articuloEncontrado == null)
                    return false; // Artículo no existe

                if (detalle.Cantidad <= 0)
                    return false; // Cantidad inválida

                if (articuloEncontrado.Inventario < detalle.Cantidad)
                    return false; // Inventario insuficiente

                bool actualizado = articulosN.DescontarInventario(articuloEncontrado.Id, detalle.Cantidad);// Se descuenta del inventario
                if (!actualizado)
                    return false; // Error actualizando inventario

                bool guardado = new DetallesAD().AgregarDetalles(detalle); // Se guarda el detalle del pedido
                if (!guardado)
                    return false; // Error insertando detalle
            }

            return true; // Todo correcto
        }
    }
}
