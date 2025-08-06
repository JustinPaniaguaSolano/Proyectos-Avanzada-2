using CapaEntidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClienteCapaPresentacion
{
    public class ClienteTCP
    {
        private static IPAddress ipServidor;
        private static TcpClient cliente;
        private static IPEndPoint serverEndPoint;
        private static StreamWriter clienteStreamWriter;
        private static StreamReader clienteStreamReader;

        private static bool conexionActiva = false;


        //Metodo para enviar un mensaje al servidor
        private static bool EnviarRespuesta(string mensaje)
        {
            try
            {
                clienteStreamWriter.WriteLine(mensaje);
                clienteStreamWriter.Flush();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static string NombreCliente { get; private set; }  // guardar el nombre recibido

        //Metodo para conectar al servidor
        public static bool Conectar(string pIdentificadorCliente)
        {
            try
            {
                ipServidor = IPAddress.Parse("127.0.0.1");
                cliente = new TcpClient();
                serverEndPoint = new IPEndPoint(ipServidor, 14100);
                cliente.Connect(serverEndPoint);

                clienteStreamReader = new StreamReader(cliente.GetStream());
                clienteStreamWriter = new StreamWriter(cliente.GetStream());

                var mensaje = new MensajeSocket<string> { Metodo = "Conectar", Entidad = pIdentificadorCliente };
                EnviarRespuesta(JsonConvert.SerializeObject(mensaje));

                string respuesta = clienteStreamReader.ReadLine();

                if (respuesta == "NO_EXISTE")
                    return false;

                NombreCliente = respuesta;
                return true;
                conexionActiva = true;

            }
            catch
            {
                return false;
            }
        }
        //Metodo para validar si el cliente existe en la base de datos
        public static bool ValidarCliente(string identificacion)
        {
            var mensaje = new MensajeSocket<string>
            {
                Metodo = "ValidarCliente",
                Entidad = identificacion
            };

            if (!EnviarRespuesta(JsonConvert.SerializeObject(mensaje)))
                return false;

            // Recibir respuesta del servidor: "true" o "false"
            var respuesta = clienteStreamReader.ReadLine();
            return bool.TryParse(respuesta, out bool resultado) && resultado;
        }
        //Metodo para obtener un cliente por su identificacion
        public static Clientes ObtenerClientePorIdentificacion(string identificacion)
        {
            try
            {
                var mensaje = new MensajeSocket<string>
                {
                    Metodo = "ObtenerClientePorIdentificacion",
                    Entidad = identificacion
                };

                if (!EnviarRespuesta(JsonConvert.SerializeObject(mensaje)))
                    return null;

                string respuesta = clienteStreamReader.ReadLine();
                if(string.IsNullOrEmpty(respuesta))
                    {
                    MessageBox.Show("No se tuvo respuestan en el servidor");
                    return null;
                }
                return JsonConvert.DeserializeObject<Clientes>(respuesta);
            }
            catch
            {
                return null;
            }
        }
        //Metodo para desconectar al cliente del servidor
        public static void Desconectar(string pIdentificadorCliente)
        {
            MensajeSocket<string> mensajeDesconectar = new MensajeSocket<string> { Metodo = "Desconectar", Entidad = pIdentificadorCliente };
            EnviarRespuesta(JsonConvert.SerializeObject(mensajeDesconectar));

            //Se cierra la conexión del cliente
            cliente.Close();
        }


        //Metodo para enviar un pedido al servidor
        public static bool EnviarPedidoConDetalles(Pedidos pedido, List<DetallesPedido> detalles)
        {
            try
            {
                // Empaquetar el pedido y los detalles en un diccionario 
                var datos = new Dictionary<string, object>
        {
            { "Pedido", pedido },
            { "Detalles", detalles }
        };

                var mensaje = new MensajeSocket<Dictionary<string, object>>
                {
                    Metodo = "AgregarPedido",
                    Entidad = datos
                };

                // Enviar
                clienteStreamWriter.WriteLine(JsonConvert.SerializeObject(mensaje));
                clienteStreamWriter.Flush();

                // Recibir respuesta
                string respuesta = clienteStreamReader.ReadLine();

                // Verificar si la respuesta es "true" o "false"
                return respuesta == "true";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al enviar pedido con detalles: " + ex.Message);
                return false;
            }
        }
        //Metodo para obtener los repartidores
        public static List<Repartidores> ObtenerRepartidores()
        {
            var mensaje = new MensajeSocket<string> { Metodo = "ObtenerRepartidores", Entidad = "" };
            EnviarRespuesta(JsonConvert.SerializeObject(mensaje));

            var respuesta = clienteStreamReader.ReadLine();
            return JsonConvert.DeserializeObject<List<Repartidores>>(respuesta);
        }
        //Metodo para obtener los articulos activos
        public static List<Articulos> ObtenerArticulosActivos()
        {
            var mensaje = new MensajeSocket<string> { Metodo = "ObtenerArticulosActivos", Entidad = "" };
            EnviarRespuesta(JsonConvert.SerializeObject(mensaje));
            string respuesta = clienteStreamReader.ReadLine();
            if (string.IsNullOrEmpty(respuesta))
            {
                MessageBox.Show("No se tuvo respuestan en el servidor");
                return null;
            }
            return JsonConvert.DeserializeObject<List<Articulos>>(respuesta);
        }

        //Metodo para obtener el detalle de un articulo por su id
        public static Articulos ObtenerDetalleArticulo(int idArticulo)
        {
            var mensaje = new MensajeSocket<int> { Metodo = "ObtenerDetalleArticulo", Entidad = idArticulo };
            EnviarRespuesta(JsonConvert.SerializeObject(mensaje));
            string respuesta = clienteStreamReader.ReadLine();
            if (string.IsNullOrEmpty(respuesta))
            {
                MessageBox.Show("No se tuvo respuestan en el servidor");
                return null;
            }
            return JsonConvert.DeserializeObject<Articulos>(respuesta);
        }
        public static List<Pedidos> ConsultarMisPedidos(string identificacion)
        {
            var mensaje = new MensajeSocket<string>
            {
                Metodo = "ConsultarPedidosCliente",
                Entidad = identificacion
            };

            EnviarRespuesta(JsonConvert.SerializeObject(mensaje));

            string respuesta = clienteStreamReader.ReadLine();
            if (string.IsNullOrEmpty(respuesta))
            {
                MessageBox.Show("No se tuvo respuestan en el servidor");
                return null;
            }

            return JsonConvert.DeserializeObject<List<Pedidos>>(respuesta) ?? new List<Pedidos>();
        }
        public static List<DetallesPedido> ObtenerDetallesPorNumeroPedido(int numeroPedido)
        {
            var mensaje = new MensajeSocket<int> { Metodo = "ObtenerDetallesPorNumeroPedido", Entidad = numeroPedido };
            EnviarRespuesta(JsonConvert.SerializeObject(mensaje));

            string respuesta = clienteStreamReader.ReadLine();
            if (string.IsNullOrEmpty(respuesta))
            {
                MessageBox.Show("No se tuvo respuestan en el servidor");
                return null;
            }
            return JsonConvert.DeserializeObject<List<DetallesPedido>>(respuesta);
        }
        public static Pedidos ConsultarPedidoPorId(string identificacionCliente, int idPedido)
        {
            var mensaje = new MensajeSocket<Dictionary<string, object>>
            {
                Metodo = "ConsultarPedidoPorId",
                Entidad = new Dictionary<string, object>
        {
            { "Identificacion", identificacionCliente },
            { "IdPedido", idPedido }
        }
            };

            EnviarRespuesta(JsonConvert.SerializeObject(mensaje));

            string respuesta = clienteStreamReader.ReadLine();
            if (string.IsNullOrEmpty(respuesta))
            {
                MessageBox.Show("No se tuvo respuestan en el servidor");
                return null;
            }

            if (respuesta == "NO_ENCONTRADO")
                return null;

            if (respuesta.StartsWith("ERROR"))
                throw new Exception(respuesta);

            return JsonConvert.DeserializeObject<Pedidos>(respuesta);
        }
        //Metodo para obtener todos los articulos
        public static List<Articulos>ObtenerArticulos()
        {
            var mensaje = new MensajeSocket<string> { Metodo = "ObtenerArticulos", Entidad = "" };
            EnviarRespuesta(JsonConvert.SerializeObject(mensaje));
            string respuesta = clienteStreamReader.ReadLine();
            if (string.IsNullOrEmpty(respuesta))
            {
                MessageBox.Show("No se obtuvo respuesta del servidor");
                return null;
            }
            return JsonConvert.DeserializeObject<List<Articulos>>(respuesta);
        }
    }
}
