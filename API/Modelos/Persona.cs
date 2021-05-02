using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Modelos
{
    public class Persona
    {
        public string Nombres { get; set; }

        public string Apellidos { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public DateTime FechaBautismo { get; set; }

        public string Telefono { get; set; }

        public string Direccion { get; set; }
    }
}
