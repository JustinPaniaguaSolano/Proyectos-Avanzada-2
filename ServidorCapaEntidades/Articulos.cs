using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    /*
             UNED SEGUNDO CUATRIMESTRE 2025
         PROYECTO 2:Aplicacion de escritorio para la gestion de articulos de la empresa Entregas S.A
      Estudiante:Justin Paniagua Solano
     Cedula:305530632
     Fecha :15/6/2025
     */


    public class Articulos:DatosArticulosHerencia
    {
        //creacion de los atributos de la clase Articulos
        public TiposArticulos TiposArticulos { get; set; }
        public double Valor { get; set; } 
        public int Inventario { get; set; }
        public bool Activo { get; set; }

        //constructores de la clase Articulos
        public Articulos(){}
        public Articulos(int id, string nombre,TiposArticulos tiposArticulos, double valor, int inventario, bool activo)
        {
            Id = id;
            Nombre = nombre;
            TiposArticulos = tiposArticulos;
            Valor = valor;
            Inventario = inventario;
            Activo = activo;
        }
        //overde del metodo ToString para mostrar el nombre del articulo
        public override string ToString()
        {
            return Nombre;
        }
    }
}
