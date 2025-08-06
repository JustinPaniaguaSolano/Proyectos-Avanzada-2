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
    //Constructor de la clase ClientesAD que inicializa la cadena de conexión a la base de datos
    public class ClientesAD
    {
        private string CadenaConexion = string.Empty;

        public ClientesAD()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["conexionBaseDatos"].ConnectionString;
        }


        //Metodo para agregar un nuevo cliente a la base de datos
        public bool AgregarClientes(Clientes clientes)
        {
            //Declaración de variables para la conexión y el comando SQL
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            bool registroAgregado = false;

            using (conexion = new SqlConnection(CadenaConexion))
            {
                // Se prepara la sentencia SQL para insertar un nuevo cliente
                string sentencia = "INSERT INTO dbo.Cliente (Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Activo) " +
                    "VALUES (@Identificacion, @Nombre, @PrimerApellido, @SegundoApellido, @FechaNacimiento, @Activo)";

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;

                //Configuracion de los parametros
                comando.Parameters.AddWithValue("@Identificacion", clientes.Identificacion);
                comando.Parameters.AddWithValue("@Nombre", clientes.Nombre);
                comando.Parameters.AddWithValue("@PrimerApellido", clientes.PrimerApellido);
                comando.Parameters.AddWithValue("@SegundoApellido", clientes.SegundoApellido);
                comando.Parameters.AddWithValue("@FechaNacimiento", clientes.FechaNacimiento);
                comando.Parameters.AddWithValue("@Activo", clientes.Activo);

                comando.Connection.Open();
                registroAgregado = comando.ExecuteNonQuery() > 0;
            }
            return registroAgregado;
        }

        // Metodo para obtener una lista de todos los clientes de la base de datos
        public List<Clientes> ObtenerClientes()
        {
            List<Clientes> ListaRetorno = new List<Clientes>();

            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                string query = "SELECT Identificacion, Nombre, PrimerApellido, SegundoApellido, FechaNacimiento, Activo FROM dbo.Cliente";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    using (SqlDataReader lector = comando.ExecuteReader())
                    {
                        while (lector.Read())
                        {
                            Clientes cliente = new Clientes
                            {
                                Identificacion = Convert.ToInt32(lector["Identificacion"]),
                                Nombre = lector["Nombre"].ToString(),
                                PrimerApellido = lector["PrimerApellido"].ToString(),
                                SegundoApellido = lector["SegundoApellido"].ToString(),
                                FechaNacimiento = Convert.ToDateTime(lector["FechaNacimiento"]),
                                Activo = Convert.ToBoolean(lector["Activo"])
                            };
                            ListaRetorno.Add(cliente);
                        }
                    }
                }
            }
            return ListaRetorno;
        }
    }
}
        

