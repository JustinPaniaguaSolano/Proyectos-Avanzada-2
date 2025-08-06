/*
   UNED SEGUNDO CUATRIMESTRE 2025
   PROYECTO 2:Agregar nuevas funcionalidades al software de la  empresa Entregas S.A
   Estudiante:Justin Paniagua Solano
   Cedula:305530632
   Fecha :27/7/2025
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
