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
    public class ClientesN
    {
        // Metodo para validar si el Cliente ya esta registrado
        public bool ValidarIdCliente(Clientes pEntidad)
        {
            bool resultado = false;
            ClientesAD ClientesAD = new ClientesAD(); // instancia de la clase ClientesAD
            List<Clientes> arreglo = ClientesAD.ObtenerClientes();// arreglo que contiene los clientes registrados
            // recorrido del arreglo

            foreach (var cliente in arreglo)
            {
                if (cliente.Identificacion == pEntidad.Identificacion)
                {
                    resultado = true; // existe el cliente
                    break;
                }
            }
           
            // si el cliente ya esta registrado se retorna false
            if (resultado)
            {
                return false;
            }
            // se guarda el cliente si no esta registrado
            else
            {
                return ClientesAD.AgregarClientes(pEntidad);
            }
        }

        //metodo para obtener los clientes registrados
        public List<Clientes> ObtenerClientes()
        {
            ClientesAD ClientesAD = new ClientesAD(); // instancia de la clase ClientesAD
            return ClientesAD.ObtenerClientes();
        }
        //Metodo para buscar un cliente por su identificacion y asi validar que exista
        public bool ExisteCliente(string identificacion)
        {
            ClientesAD clientesAD = new ClientesAD(); // instancia de la clase ClientesAD
            if (int.TryParse(identificacion, out int id))
            {
                List<Clientes> listaClientes = clientesAD.ObtenerClientes();

                foreach (Clientes cliente in listaClientes)
                {
                    if (cliente.Identificacion == id)
                    {
                        return true; // cliente encontrado
                    }
                }

                return false; // no se encontró el cliente
            }
            else
            {
                return false; // identificación no es un número válido
            }
        }

        // Metodo para buscar un cliente por su identificacion
        public Clientes BuscarClientePorIdentificacion(string identificacion)
        {
            ClientesAD clientesAD = new ClientesAD(); // instancia de la clase ClientesAD
            List<Clientes> Clientes = clientesAD.ObtenerClientes();// obtiene la lista de clientes registrados

            foreach (Clientes cliente in Clientes)
            {
                if (cliente.Identificacion.ToString() == identificacion)
                {
                    return cliente; // se encontró el cliente
                }
            }

            return null; // no se encontró ningún cliente con esa identificación
        }
    }
}
