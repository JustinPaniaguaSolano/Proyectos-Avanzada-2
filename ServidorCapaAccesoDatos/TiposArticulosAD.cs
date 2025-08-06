using CapaEntidades;

using System.Configuration;
using System.Data.SqlClient;

namespace CapaAccesoDatos
/*
   UNED SEGUNDO CUATRIMESTRE 2025
   PROYECTO 2:Agregar nuevas funcionalidades al software de la  empresa Entregas S.A
   Estudiante:Justin Paniagua Solano
   Cedula:305530632
   Fecha :27/7/2025
   */
{
    //Acceder a la base de datos para ingresar y sacar informacion ,idea principal sacada de la tutoria de Juan Ramirez Vallares
    //https://www.youtube.com/watch?v=0GTGyA3f4VY
    public class TiposArticulosAD
    {
        // Cadena de conexión a la base de datos, se obtiene del archivo de configuración
        private string CadenaConexion = string.Empty;

        // Constructor de la clase, inicializa la cadena de conexión a partir del archivo de configuración
        public TiposArticulosAD( )
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["conexionBaseDatos"].ConnectionString;
        }

        // Método para agregar un nuevo tipo de artículo a la base de datos
        public bool AgregarTipoArticulo(TiposArticulos tipoArticulo)
        {
            //Declaración de variables para la conexión y el comando SQL
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            bool registroAgregado = false;

            using (conexion = new SqlConnection(CadenaConexion))
            {
                // Se prepara la sentencia SQL para insertar un nuevo tipo de artículo
                string sentencia = "INSERT INTO dbo.TipoArticulo (Id,Nombre,Descripcion )" +
                    "VALUES (@Id, @Nombre, @Descripcion)";
                // Se configura el comando SQL
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;
                //Configuracion de los parametros 
                comando.Parameters.AddWithValue("@Id", tipoArticulo.Id);
                comando.Parameters.AddWithValue("@Nombre", tipoArticulo.Nombre);
                comando.Parameters.AddWithValue("@Descripcion", tipoArticulo.Descripcion);
                // Se abre la conexión a la base de datos
                comando.Connection.Open();
                registroAgregado = comando.ExecuteNonQuery() > 0;
            }
            return registroAgregado;
        }

        // Método para obtener todos los tipos de artículos de la base de datos
        public List<TiposArticulos>ObtenerTiposArticulos()
        {
            List<TiposArticulos> ListaRetorno = new List<TiposArticulos>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            using (conexion = new SqlConnection(CadenaConexion))
            {
                // Se prepara la sentencia SQL para seleccionar todos los tipos de artículos
                comando.CommandText = "Select Id, Nombre,Descripcion FROM dbo.TipoArticulo";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion;
                // Se abre la conexión a la base de datos y se ejecuta el comando
                comando.Connection.Open();
                lector = comando.ExecuteReader();
                //While se utiliza para leer los resultados de la consulta
                while (lector.Read())
                {
                    TiposArticulos tipoArticulo = new TiposArticulos
                    {
                        Id = Convert.ToInt32(lector["Id"]),
                        Nombre = lector["Nombre"].ToString(),
                        Descripcion = lector["Descripcion"].ToString(),
                    };
                    ListaRetorno.Add(tipoArticulo);
                }
            }
            return ListaRetorno;
        }
    }
}
