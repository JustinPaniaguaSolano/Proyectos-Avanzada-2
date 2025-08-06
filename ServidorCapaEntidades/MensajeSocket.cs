using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    public class MensajeSocket<T>
    {
        public string Metodo { get; set; }
        //Se reaalizo con JToken para que pueda recibir cualquier tipo de entidad
        public JToken Entidad { get; set; }
}
}
