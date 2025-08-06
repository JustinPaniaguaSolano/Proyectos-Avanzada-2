/*
   UNED SEGUNDO CUATRIMESTRE 2025
   PROYECTO 2:Agregar nuevas funcionalidades al software de la  empresa Entregas S.A
   Estudiante:Justin Paniagua Solano
   Cedula:305530632
   Fecha :27/7/2025
*/
namespace CapaEntidades
{
    //Clase con los atributos de los pedidos
    public class Pedidos
    {
        public int NumeroPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public Clientes clientes { get; set; }
        public Repartidores repartidores { get; set; }
        public string Direccion { get; set; }

        //Constructor de la clase Pedidos
        public Pedidos() { }
        public Pedidos(int numeroPedido, DateTime fechaPedido, Clientes clientes, Repartidores repartidores, string direccion)
        {
            NumeroPedido = numeroPedido;
            FechaPedido = fechaPedido;
            this.clientes = clientes;
            this.repartidores = repartidores;
            Direccion = direccion;
        }
        public override string ToString()
        {
            return $"Pedido #{NumeroPedido} - Cliente: {clientes.Nombre} {clientes.PrimerApellido} - Repartidor: {repartidores.Nombre} {repartidores.PrimerApellido} - Fecha: {FechaPedido.ToShortDateString()} - Dirección: {Direccion}";
        }
    }
}
