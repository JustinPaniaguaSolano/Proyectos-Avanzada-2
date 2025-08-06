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

    public class Clientes : Personas
    {
        //creacion de los atributos de la clase Clientes
        public Clientes() { }

        // Constructor con parámetros para inicializar los atributos
        public Clientes(int identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, bool activo)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            FechaNacimiento = fechaNacimiento;
            Activo = activo;
        }
        
        public override string ToString()
        {
            // Retorna el nombre completo del cliente como una representación de cadena
            return Nombre ;
        }

    }
}
