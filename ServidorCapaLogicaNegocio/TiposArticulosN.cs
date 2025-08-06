using CapaEntidades;
using CapaAccesoDatos;
namespace CapaLogicaNegocio
/*
   UNED SEGUNDO CUATRIMESTRE 2025
   PROYECTO 2:Agregar nuevas funcionalidades al software de la  empresa Entregas S.A
   Estudiante:Justin Paniagua Solano
   Cedula:305530632
   Fecha :27/7/2025
*/
{
    public class TiposArticulosN
    {
        // Metodo para validar si el Tipo de Articulo ya esta registrado
        public bool ValidarTipoArticulo(TiposArticulos pEntidad)
        {
            bool resultado = false;
            TiposArticulosAD TiposArticulosAD = new TiposArticulosAD(); // instancia de la clase TiposArticulosAD
            List<TiposArticulos> arreglo = TiposArticulosAD.ObtenerTiposArticulos();

            foreach (var tiposArticulo in arreglo)
            {
                if (tiposArticulo.Id == pEntidad.Id)
                {
                    resultado = true; // existe el cliente
                    break;
                }
            }
            if (resultado)
            {
                return false;
            }
            else
            {
                return TiposArticulosAD.AgregarTipoArticulo(pEntidad);
            }
        }
        // Metodo para obtener los tipos de articulos registrados
        public List<TiposArticulos> ObtenerTiposArticulos()
        {
            TiposArticulosAD TiposArticulosAD = new TiposArticulosAD(); // instancia de la clase TiposArticulosAD
            return TiposArticulosAD.ObtenerTiposArticulos();
        }
    }
}
