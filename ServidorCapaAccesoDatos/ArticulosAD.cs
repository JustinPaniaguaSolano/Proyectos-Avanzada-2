using CapaEntidades;
using System.Configuration;
using System.Data.SqlClient;

/*
   UNED SEGUNDO CUATRIMESTRE 2025
   PROYECTO 2:Agregar nuevas funcionalidades al software de la  empresa Entregas S.A
   Estudiante:Justin Paniagua Solano
   Cedula:305530632
   Fecha :27/7/2025
 */
namespace CapaAccesoADatos
{
    //Acceder a la base de datos para ingresar y sacar informacion ,idea principal sacada de la tutoria de Juan Ramirez Vallares
    //https://www.youtube.com/watch?v=0GTGyA3f4VY
    public class ArticulosAD
    {
        //Constuctor con su cadena de conexion a la base de datos obtenida del app config en la capa de presentacion
        public ArticulosAD()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["conexionBaseDatos"].ConnectionString;
        }

        private string CadenaConexion = string.Empty;

        //Metodo para agregar un articulo a la base de datos
        public bool AgregarArticulo(Articulos articulos)
        {
            
            SqlConnection conexion;// Conexion a la base de datos
            SqlCommand comando = new SqlCommand();// Comando para ejecutar la sentencia SQL
            bool registroAgregado = false;//Bandera para indicar si el registro fue agregado correctamente


            using (conexion = new SqlConnection(CadenaConexion))//Se rea una nueva conexion a la base de datos usando la cadena de conexion
            {
                // Sentencia SQL para insertar un nuevo articulo en la tabla Articulo
                string sentencia = "INSERT INTO dbo.Articulo  (Id,Nombre,IdTipoArticulo,Valor,Inventario,Activo) " +
                                    "VALUES (@Id, @Nombre, @IdTipoArticulo, @Valor, @Inventario, @Activo)";

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;
                // Se agregan los parametros a la consulta SQL para evitar inyecciones SQL
                comando.Parameters.AddWithValue("@ID", articulos.Id);
                comando.Parameters.AddWithValue("@Nombre", articulos.Nombre);
                comando.Parameters.AddWithValue("@IdTipoArticulo", articulos.TiposArticulos.Id);
                comando.Parameters.AddWithValue("@Valor", articulos.Valor);
                comando.Parameters.AddWithValue("@Inventario", articulos.Inventario);
                comando.Parameters.AddWithValue("@Activo", articulos.Activo);

                // Se abre la conexion a la base de datos y se ejecuta el comando
                comando.Connection.Open();
                registroAgregado = comando.ExecuteNonQuery() > 0;
            }
            return registroAgregado;
        }
        //Metodo para obtener todos los articulos de la base de datos
        public List<Articulos> ObtenerArticulos()
        {
            List<Articulos> ListaRetorno = new List<Articulos>();
            //Cadena de conexion a la base de datos
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            using (conexion = new SqlConnection(CadenaConexion))
            {
             
                comando.CommandText = @"
                                    SELECT 
                                        A.Id, A.Nombre, A.IdTipoArticulo, A.Valor, A.Inventario, A.Activo,
                                        TA.Nombre AS NombreTipoArticulo, TA.Descripcion AS DescripcionTipoArticulo
                                    FROM Articulo A
                                    JOIN TipoArticulo TA ON A.IdTipoArticulo = TA.Id";

                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion; // Asignar la conexión al comando
                // Se abre la conexión a la base de datos y se ejecuta el comando
                comando.Connection.Open();
                lector = comando.ExecuteReader();
                //Lectura de los datos obtenidos de la base de datos
                while (lector.Read())
                {
                    Articulos articulo = new Articulos
                    {
                        Id = Convert.ToInt32(lector["Id"]),
                        Nombre = lector["Nombre"].ToString(),

                        TiposArticulos = new TiposArticulos
                        {
                            Id = Convert.ToInt32(lector["IdTipoArticulo"]),
                            Nombre = lector["NombreTipoArticulo"].ToString(),
                            Descripcion = lector["DescripcionTipoArticulo"].ToString()
                        },

                        Valor = Convert.ToInt32(lector["Valor"]),
                        Inventario = Convert.ToInt32(lector["Inventario"]),
                        Activo = Convert.ToBoolean(lector["Activo"])
                    };
                    ListaRetorno.Add(articulo);
                }
            }
            return ListaRetorno;
        }
        //Metodo para actualizar el inventario de un articulo en la base de datos
        public bool ActualizarInventario(int idArticulo, int nuevoInventario)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                string sentencia = @"
                        UPDATE Articulo
                        SET Inventario = @Inventario,
                          Activo = @Activo
                            WHERE Id = @Id";

                SqlCommand comando = new SqlCommand(sentencia, conexion);
                comando.Parameters.AddWithValue("@Inventario", nuevoInventario);
                comando.Parameters.AddWithValue("@Activo", nuevoInventario > 0 ? 1 : 0);// Si el inventario es mayor que 0, se activa el articulo, de lo contrario se desactiva
                comando.Parameters.AddWithValue("@Id", idArticulo);

                conexion.Open();
                int filasAfectadas = comando.ExecuteNonQuery();

                return filasAfectadas > 0;
            }
        }
    }
}
