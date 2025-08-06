/*
   UNED SEGUNDO CUATRIMESTRE 2025
   PROYECTO 2:Agregar nuevas funcionalidades al software de la  empresa Entregas S.A
   Estudiante:Justin Paniagua Solano
   Cedula:305530632
   Fecha :27/7/2025
*/
namespace CapaEntidades
{
    //clase con los detalles de los pedidos
    public class Repartidores: Personas
    {
        public DateTime FechaContractacion { get; set; }

        //constructor de la clase Repartidores
        public Repartidores() { }
        public Repartidores(int identificacion, string nombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, DateTime fechaContractacion,bool activo)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            FechaNacimiento = fechaNacimiento;
            FechaContractacion = fechaContractacion;
            Activo = activo;
        }
    }
}
