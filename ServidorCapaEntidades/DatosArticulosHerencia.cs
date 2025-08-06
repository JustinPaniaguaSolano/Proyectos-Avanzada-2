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
    //Clase para heredar los datos de los articulos
    public class DatosArticulosHerencia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        
      
      
        public DatosArticulosHerencia() { }
        // Constructor con parámetros
        public DatosArticulosHerencia(int id, string nombre, string descripcion, decimal precio, int stock)
        {
            Id = id;
            Nombre = nombre;
           
        }
    }
}
