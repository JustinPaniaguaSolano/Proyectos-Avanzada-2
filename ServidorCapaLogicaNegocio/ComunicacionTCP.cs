using System.Net.Sockets;

/*
   UNED SEGUNDO CUATRIMESTRE 2025
   PROYECTO 2:Agregar nuevas funcionalidades al software de la  empresa Entregas S.A
   Estudiante:Justin Paniagua Solano
   Cedula:305530632
   Fecha :27/7/2025
*/

namespace CapaLogicaNegocio
{
    public class ComunicacionTCP
    {
        //Idea de la clase sacada de la tutoria#2 de Juan Ramirez Vallares
        //https://www.youtube.com/watch?v=0GTGyA3f4VY&feature=youtu.be
        private TcpListener tcpListener;// Escucha de conexiones TCP entrantes
        private bool servidorIniciado;// Indica si el servidor está en funcionamiento
        private Semaphore semaforoConexiones = new Semaphore(5, 5); // Semaforo para limitar el número de conexiones simultáneas (5 conexiones)

        //Eventose se disparan cuando se recibe un mensaje o cuando un cliente es rechazado
        public event EventHandler<(string mensaje,StreamWriter streamWriter)> MensajeRecibido;
        public event EventHandler<string> ClienteRechazado;

        //Método constructor de la clase ComunicacionTCP
        public ComunicacionTCP()
        {
            // Inicializa el TcpListener en la dirección local y puerto 14100
            var local = System.Net.IPAddress.Parse("127.0.0.1");
            tcpListener = new TcpListener(local, 14100);
        }
        // Método para iniciar el servidor TCP
        public void Iniciar()
        {
            servidorIniciado = true;//Bandera para indicar que el servidor ha iniciado
            tcpListener.Start();// Comienza a escuchar conexiones entrantes

            //Hilo para escuchar clientes en segundo plano
            var subprocesoEscuchaClientes = new Thread(EscucharClientes);
            subprocesoEscuchaClientes.IsBackground = true;
            subprocesoEscuchaClientes.Start();
        }
        // Método para detener el servidor TCP
        public void Detener()
        {
            servidorIniciado = false;// Bandera para indicar que el servidor ha detenido
            tcpListener.Stop();//detener el servidor

            // Interrumpe el hilo de escucha de clientes si está en ejecución
            var subprocesoEscuchaClientes = new Thread(EscucharClientes);
            subprocesoEscuchaClientes.IsBackground = true;
            subprocesoEscuchaClientes.Interrupt();// Interrumpe el hilo de escucha de clientes
        }
        // Método para escuchar conexiones entrantes de clientes
        private void EscucharClientes()
        {
            while (servidorIniciado)
            {
                try
                {
                    var client = tcpListener.AcceptTcpClient(); // Acepta una conexión entrante

                    if (!semaforoConexiones.WaitOne(0)) //  No hay espacio para aceptar
                    {

                        using (var writer = new StreamWriter(client.GetStream()))
                        {
                            writer.WriteLine("Servidor lleno. Intente más tarde.");
                            writer.Flush();
                        }

                        client.Close();// Cierra la conexión del cliente
                        ClienteRechazado?.Invoke(this, "Cliente rechazado por límite de conexiones.");//Se muestra en la bitacora del servidor
                        continue;
                    }

                    //En caso de que haya espacio, se crea un hilo para manejar la comunicación con el cliente
                    var ClientThread = new Thread(() =>
                    {
                        ComunicacionCliente(client);//Se atiende el cliente
                        semaforoConexiones.Release();// Libera el semáforo cuando se termina de atender al cliente
                    });

                    ClientThread.IsBackground = true;
                    ClientThread.Start();
                }
                catch (SocketException ex)
                {
                    Console.WriteLine($"Error de socket: {ex.Message}");// Muestra el error en la consola
                }
            }
        }

        // Método para manejar la comunicación con el cliente
        private void ComunicacionCliente(object cliente)
        {
            var tcpClient = (TcpClient)cliente;
            var reader = new StreamReader(tcpClient.GetStream());// Crea un lector para leer mensajes del cliente
            var writer = new StreamWriter(tcpClient.GetStream());// Crea un escritor para enviar mensajes al cliente

            while (servidorIniciado)
            {
                try
                {
                    var mensaje = reader.ReadLine();// Lee un mensaje del cliente   
                    if (mensaje==null)
                        break; // Si el mensaje es nulo, significa que el cliente ha cerrado la conexión
                    MensajeRecibido?.Invoke(this, (mensaje, writer));// Dispara el evento MensajeRecibido con el mensaje y el escritor
                }
                catch(IOException)
                {
                    break;// Cliente se desconecto o uno un error de red
                }
            }
            tcpClient.Close();// Cierra la conexión del cliente
        }
    }
}
