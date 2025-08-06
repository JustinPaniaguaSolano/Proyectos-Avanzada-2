/*
   UNED SEGUNDO CUATRIMESTRE 2025
   PROYECTO 2:Agregar nuevas funcionalidades al software de la  empresa Entregas S.A
   Estudiante:Justin Paniagua Solano
   Cedula:305530632
   Fecha :27/7/2025
*/
namespace CapaEntidades
{
    //clase para heredar los atributos de las personas
    public class Personas
    {
        public int Identificacion { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool Activo { get; set; }

    }
}
