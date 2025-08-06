/*
   UNED SEGUNDO CUATRIMESTRE 2025
   PROYECTO 2:Agregar nuevas funcionalidades al software de la  empresa Entregas S.A
   Estudiante:Justin Paniagua Solano
   Cedula:305530632
   Fecha :27/7/2025
*/
namespace CapaEntidades
{
    //clase con los atributos de los detalles del pedido
    public class DetallesPedido
    {
        public int NumeroPedido { get; set; }
        public int IDArticulo { get; set; }
        public Articulos Articulos { get; set; }
        public int Cantidad { get; set; }
        public double Monto { get; set; }

        //constructor de la clase DetallesPedido
        public DetallesPedido() { }
        public DetallesPedido(int numeroPedido, Articulos Articulos, int cantidad)
        {
            NumeroPedido = numeroPedido;
            Articulos = Articulos;
            IDArticulo = Articulos.Id;
            Cantidad = cantidad;
            Monto = Articulos.Valor*cantidad*1.12;
        }
    }
}
