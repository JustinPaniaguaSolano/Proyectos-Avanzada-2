using CapaAccesoADatos;
using CapaEntidades;

/*
   UNED SEGUNDO CUATRIMESTRE 2025
   PROYECTO 2:Agregar nuevas funcionalidades al software de la  empresa Entregas S.A
   Estudiante:Justin Paniagua Solano
   Cedula:305530632
   Fecha :27/7/2025
*/
namespace CapaLogicaNegocio
{
    public class RepartidoresN
    {
        // Metodo para validar si el Repartidor ya esta registrado
        public bool ValidarIdRepartidor(Repartidores pEntidad)
        {
            bool resultado = false;
            RepartidoresAD RepartidoresAD = new RepartidoresAD();// instancia de la clase RepartidoresAD
            List<Repartidores> arreglo = RepartidoresAD.ObtenerRepartidores();

            for (int i = 0; i < arreglo.Count; i++)// recorre el arreglo de repartidores
            {
                if (arreglo[i] != null && arreglo[i].Identificacion == pEntidad.Identificacion)// verifica si el repartidor ya existe
                {
                    resultado = true;// si existe se cambia el valor de resultado a true
                    break;
                }
            }
            if (resultado)
            {
                return false;
            }
            // se guarda el repartidor si no esta registrado
            else
            {
                return RepartidoresAD.AgregarRepartidores(pEntidad);
            }
        }

        // Metodo para validar que el Repartidor sea mayor de edad
        public bool ValidarEdad(DateTime FechaNaci)
        {
            DateTime hoy = DateTime.Now;
            int edad = hoy.Year - FechaNaci.Year;
            if (FechaNaci > hoy.AddYears(-edad)) edad--;// Ajusta la edad si el cumpleaños aún no ha ocurrido este año
            return edad >= 18; // Verifica si la edad es mayor o igual a 18
        }
        // Metodo para validar que la fecha de contratacion no sea futura
        public bool ValidarFechaContratacion(DateTime FechaContratacion)
        {
            DateTime hoy = DateTime.Now;
            return FechaContratacion <= hoy; 
        }

        //metodo para obtener los repartidores registrados
        public List<Repartidores> ObtenerRepartidores()
        {
            RepartidoresAD RepartidoresAD = new RepartidoresAD();// instancia de la clase RepartidoresAD
            return RepartidoresAD.ObtenerRepartidores();
        }
    }
}
