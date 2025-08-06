
/*
   UNED SEGUNDO CUATRIMESTRE 2025
   PROYECTO 2:Agregar nuevas funcionalidades al software de la  empresa Entregas S.A
   Estudiante:Justin Paniagua Solano
   Cedula:305530632
   Fecha :27/7/2025
*/
namespace CapaEntidades
{
  
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
