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
    public class ArticulosN
    {
    //Metodo para validar si el Articulo ya esta registrado
        public bool ValidarArticulo(Articulos pEntidad)
        {
            bool resultado = false;
            ArticulosAD articulosAD = new ArticulosAD();
            List<Articulos> arreglo = articulosAD.ObtenerArticulos();//arreglo que contiene los articulos registrados

            //recorrido del arreglo
            foreach (var articulo in arreglo)
            {
                if (articulo.Id == pEntidad.Id)
                {
                    resultado = true; // existe el cliente
                    break;
                }
            }
            //si el articulo ya esta registrado se retorna false    
            if (resultado)
            {
                return false;
            }
            //se guarda el articulo si no esta registrado
            else
            {
                return articulosAD.AgregarArticulo(pEntidad);
            }
        }
        //Metodo para obtener los articulos registrados
        public List<Articulos> ObtenerArticulos()
        {
            ArticulosAD articulosAD = new ArticulosAD();
            return articulosAD.ObtenerArticulos();

        }

        //metodo para buscar un articulo por su id
        public Articulos BuscarTipoArticulo(int id)
        {
            var Articulos = ObtenerArticulos();//se obtiene el arreglo de articulos registrados
            if (Articulos == null) return null;//si el arreglo es nulo se retorna null
            //se recorre el arreglo para buscar el articulo por su id
            for (int i = 0; i < Articulos.Count; i++)
            {
                var articulo = Articulos[i];
                if (articulo != null && articulo.Id == id)
                    return articulo;// si se encuentra el articulo se retorna
            }
            return null;// si no se encuentra el articulo se retorna null
        }

        //Metodo para restar cantidad de un articulo
        public bool DescontarInventario(int idArticulo, int cantidad)
        {
            ArticulosAD articulosAD = new ArticulosAD();

            // Obtener lista de artículos
            var Articulos = articulosAD.ObtenerArticulos();
            Articulos articuloEncontrado = null;// Variable para almacenar el artículo encontrado

            // Buscar el artículo con el ID proporcionado
            foreach (var articulo in Articulos)
            {
                if (articulo.Id == idArticulo)
                {
                    articuloEncontrado = articulo;
                    break;
                }
            }

            if (articuloEncontrado == null)
                return false; // Artículo no existe

            if (articuloEncontrado.Inventario < cantidad)
                return false; // Inventario insuficiente

            // Calcular nuevo inventario
            int nuevoInventario = articuloEncontrado.Inventario - cantidad;

            // Actualizar inventario en la base de datos
            return articulosAD.ActualizarInventario(idArticulo, nuevoInventario);
        }
    }
}

