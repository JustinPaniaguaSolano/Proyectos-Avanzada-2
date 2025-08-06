using CapaEntidades;
using System.Data.SqlClient;
using System.Configuration;

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

    //Constructor de la clase DetallesAD que inicializa la cadena de conexión a la base de datos
    public class DetallesAD
    {
        private string CadenaConexion = string.Empty;

        public DetallesAD()
        {
            CadenaConexion = ConfigurationManager.ConnectionStrings["conexionBaseDatos"].ConnectionString;
        }
        // Método para agregar un nuevo detalle de pedido a la base de datos
        public bool AgregarDetalles(DetallesPedido detallesPedido)
        {
            //Declaración de variables para la conexión y el comando SQL
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            bool registroAgregado = false;
            // Se crea una nueva conexión a la base de datos usando la cadena de conexión
            using (conexion = new SqlConnection(CadenaConexion))
            {
                // Se prepara la sentencia SQL para insertar un nuevo detalle de pedido
                string sentencia = "INSERT INTO dbo.DetallePedido (Idpedido, Idarticulo, Cantidad, Monto) " +
                   "VALUES (@Idpedido, @Idarticulo, @Cantidad, @Monto)";

                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = conexion;
                // Se agregan los parámetros a la consulta SQL para evitar inyecciones SQL
                comando.Parameters.AddWithValue("@Idpedido", detallesPedido.NumeroPedido);
                comando.Parameters.AddWithValue("@Idarticulo", detallesPedido.IDArticulo);
                comando.Parameters.AddWithValue("@Cantidad", detallesPedido.Cantidad);
                comando.Parameters.AddWithValue("@Monto", detallesPedido.Monto);
                
                comando.Connection.Open();
                registroAgregado = comando.ExecuteNonQuery() > 0;
            }
            return registroAgregado;// Retorna true si el registro fue agregado correctamente, false en caso contrario
        }

        //Metodo para obtener TODOS los detalles de pedidos de la base de datos
        public List<DetallesPedido> ObtenerDetallesPedidos()
        {
            List<DetallesPedido> ListaRetorno = new List<DetallesPedido>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            using (conexion = new SqlConnection(CadenaConexion))
            {
                // Se prepara la consulta SQL para obtener todos los detalles de pedidos
                comando.CommandText = "Select Idpedido, Idarticulo,Cantidad,Monto FROM dbo.DetallePedido";
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion; // Asignar la conexión al comando
                comando.Connection.Open();
                lector = comando.ExecuteReader();
                //While se utiliza para leer los resultados de la consulta
                while (lector.Read())
                {
                    DetallesPedido detalles = new DetallesPedido
                    {
                        NumeroPedido = Convert.ToInt32(lector["Idpedido"]),
                        IDArticulo = Convert.ToInt32(lector["Idarticulo"]),
                        Cantidad = Convert.ToInt32(lector["Cantidad"]),
                        Monto = Convert.ToInt32(lector["Monto"])
                    };
                    ListaRetorno.Add(detalles);
                }
            }
            return ListaRetorno;
        }
        // Método para obtener los detalles de UN pedido específico por su número
        public List<DetallesPedido> ObtenerDetallesPorNumeroPedido(int numeroPedido)
        {
            List<DetallesPedido> ListaRetorno = new List<DetallesPedido>();
            SqlConnection conexion;
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            using (conexion = new SqlConnection(CadenaConexion))
            {
                //Preparar la consulta SQL para obtener los detalles de un pedido específico
                comando.CommandText = "SELECT Idpedido, Idarticulo, Cantidad, Monto FROM dbo.DetallePedido WHERE Idpedido = @NumeroPedido";
                comando.Parameters.AddWithValue("@NumeroPedido", numeroPedido);
                comando.CommandType = System.Data.CommandType.Text;
                comando.Connection = conexion; // Asignar la conexión al comando
                comando.Connection.Open();
                lector = comando.ExecuteReader();
                //While se utiliza para leer los resultados de la consulta
                while (lector.Read())
                {
                    DetallesPedido detalles = new DetallesPedido
                    {
                        NumeroPedido = Convert.ToInt32(lector["Idpedido"]),
                        IDArticulo = Convert.ToInt32(lector["Idarticulo"]),
                        Cantidad = Convert.ToInt32(lector["Cantidad"]),
                        Monto = Convert.ToDouble(lector["Monto"])
                    };
                    ListaRetorno.Add(detalles);
                }
            }
            return ListaRetorno;
        }
    }
}
