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
    public class PedidosAD
    {
        private string CadenaConexion = string.Empty;

        // Constructor de la clase PedidosAD que inicializa la cadena de conexión a la base de datos
        public PedidosAD()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["conexionBaseDatos"].ConnectionString;
        }
        // Método para agregar un nuevo pedido a la base de datos y se obtiene su ID generado automáticamente
        public int AgregarPedidoYObtenerId(Pedidos pedido)
        {
            using (SqlConnection conexion = new SqlConnection(CadenaConexion))
            {
                // Se prepara la consulta SQL para insertar un nuevo pedido y obtener su ID
                string sql = @"
            INSERT INTO Pedido (FechaPedido, IdCliente, IdRepartidor, Direccion)
            VALUES (@FechaPedido, @IdCliente, @IdRepartidor, @Direccion);
            SELECT CAST(SCOPE_IDENTITY() AS INT);";

                SqlCommand comando = new SqlCommand(sql, conexion);
                // Se agregan los parámetros a la consulta SQL para evitar inyecciones SQL
                comando.Parameters.AddWithValue("@FechaPedido", pedido.FechaPedido);
                comando.Parameters.AddWithValue("@IdCliente", pedido.clientes.Identificacion);
                comando.Parameters.AddWithValue("@IdRepartidor", pedido.repartidores.Identificacion);
                comando.Parameters.AddWithValue("@Direccion", pedido.Direccion);

                conexion.Open();
                return (int)comando.ExecuteScalar(); //Devuelve el ID del pedido recién insertado
            }
        }
        // Método para obtener TODOS los pedidos de la base de datos
        public List<Pedidos> ObtenerPedidos()
        {
            List<Pedidos> ListaRetorno = new List<Pedidos>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            using (conexion = new SqlConnection(CadenaConexion))
            {
                comando.CommandText = @"
                                    SELECT 
                                        dbo.Pedido.Id,
                                        dbo.Pedido.FechaPedido,
    
                                        dbo.Cliente.Identificacion AS IdCliente,
                                        dbo.Cliente.Nombre AS NombreCliente,
                                        dbo.Cliente.PrimerApellido AS Apellido1Cliente,
                                        dbo.Cliente.SegundoApellido AS Apellido2Cliente,

                                        dbo.Repartidor.Identificacion AS IdRepartidor,
                                        dbo.Repartidor.Nombre AS NombreRepartidor,
                                        dbo.Repartidor.PrimerApellido AS Apellido1Repartidor,
                                        dbo.Repartidor.SegundoApellido AS Apellido2Repartidor,

                                        dbo.Pedido.Direccion
                                    FROM 
                                        dbo.Pedido
                                    INNER JOIN 
                                        dbo.Cliente ON dbo.Pedido.IdCliente = dbo.Cliente.Identificacion
                                    INNER JOIN 
                                        dbo.Repartidor ON dbo.Pedido.IdRepartidor = dbo.Repartidor.Identificacion";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion; // Asignar la conexión al comando
                comando.Connection.Open();
                lector = comando.ExecuteReader();

                // Se utiliza un bucle while para leer los resultados de la consulta
                while (lector.Read())
                {
                    Pedidos pedidos = new Pedidos
                    {
                        NumeroPedido = Convert.ToInt32(lector["Id"]),
                        FechaPedido = Convert.ToDateTime(lector["FechaPedido"]),
                        clientes = new Clientes
                        {
                            Identificacion = Convert.ToInt32(lector["IdCliente"]),
                            Nombre = lector["NombreCliente"].ToString(),
                            PrimerApellido = lector["Apellido1Cliente"].ToString(),
                            SegundoApellido = lector["Apellido2Cliente"].ToString()
                        },
                        repartidores = new Repartidores
                        {
                            Identificacion = Convert.ToInt32(lector["IdRepartidor"]),
                            Nombre = lector["NombreRepartidor"].ToString(),
                            PrimerApellido = lector["Apellido1Repartidor"].ToString(),
                            SegundoApellido = lector["Apellido2Repartidor"].ToString()
                        },
                        Direccion = lector["Direccion"].ToString()
                    };
                    ListaRetorno.Add(pedidos);
                }
            }
            return ListaRetorno;
        }
        }
    }
    

