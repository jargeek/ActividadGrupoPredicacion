using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Modelos
{
    public class Publicador : Persona
    {
        public bool Ungido { get; set; }

        public bool Inactivo { get; set; }

        public bool Bautizado { get; set; }
    }
}
