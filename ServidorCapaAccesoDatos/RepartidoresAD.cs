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
    public class RepartidoresAD
    {
        private string CadenaConexion = string.Empty;

        // Constructor de la clase RepartidoresAD que inicializa la cadena de conexión a la base de datos
        public RepartidoresAD()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["conexionBaseDatos"].ConnectionString;
        }
        // Método para agregar un nuevo repartidor a la base de datos
        public bool AgregarRepartidores(Repartidores repartidores)
        {
            //Declaración de variables para la conexión y el comando SQL
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            bool registroAgregado = false;

            using (conexion = new SqlConnection(CadenaConexion))
            {
                // Se prepara la sentencia SQL para insertar un nuevo repartidor
                string sentencia = "INSERT INTO dbo.Repartidor (Identificacion,Nombre,PrimerApellido,SegundoApellido,FechaNacimiento,FechaContratacion,Activo)" +
                    "VALUES (@Identificacion,@Nombre ,@PrimerApellido, @SegundoApellido,@FechaNacimiento,@FechaContratacion,@Activo)";

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;
                //Configuracion de los parametros
                comando.Parameters.AddWithValue("@Identificacion", repartidores.Identificacion);
                comando.Parameters.AddWithValue("@Nombre", repartidores.Nombre);
                comando.Parameters.AddWithValue("@PrimerApellido", repartidores.PrimerApellido);
                comando.Parameters.AddWithValue("@SegundoApellido", repartidores.SegundoApellido);
                comando.Parameters.AddWithValue("@FechaNacimiento", repartidores.FechaNacimiento);
                comando.Parameters.AddWithValue("@FechaContratacion", repartidores.FechaContractacion);
                comando.Parameters.AddWithValue("@Activo", repartidores.Activo);

                comando.Connection.Open();
                registroAgregado = comando.ExecuteNonQuery() > 0;
            }
            return registroAgregado;
        }

        // Método para obtener todos los repartidores de la base de datos
        public List<Repartidores> ObtenerRepartidores()
        {
            List<Repartidores> ListaRetorno = new List<Repartidores>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            using (conexion = new SqlConnection(CadenaConexion))
            {
                comando.CommandText = "Select Identificacion, Nombre,PrimerApellido,SegundoApellido,FechaContratacion,FechaNacimiento,Activo FROM dbo.Repartidor";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion; // Asignar la conexión al comando
                comando.Connection.Open();
                lector = comando.ExecuteReader();
                // Se utiliza un bucle while para leer los resultados de la consulta
                while (lector.Read())
                {
                    Repartidores repartidores = new Repartidores
                    {
                        Identificacion = Convert.ToInt32(lector["Identificacion"]),
                        Nombre = lector["Nombre"].ToString(),
                        PrimerApellido = lector["PrimerApellido"].ToString(),
                        SegundoApellido = lector["SegundoApellido"].ToString(),
                        FechaContractacion= Convert.ToDateTime(lector["FechaContratacion"]),
                        FechaNacimiento = Convert.ToDateTime(lector["FechaNacimiento"]),
                        Activo= Convert.ToBoolean(lector["Activo"])
                    };
                    ListaRetorno.Add(repartidores);
                }
            }
            return ListaRetorno;
        }
    }
}
