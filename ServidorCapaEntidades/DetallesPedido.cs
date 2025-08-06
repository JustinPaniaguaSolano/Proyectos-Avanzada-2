using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
            UNED SEGUNDO CUATRIMESTRE 2025
        PROYECTO 1:Aplicacion de escritorio para la gestion de articulos de la empresa Entregas S.A
     Estudiante:Justin Paniagua Solano
    Cedula:305530632
    Fecha :15/6/2025
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
