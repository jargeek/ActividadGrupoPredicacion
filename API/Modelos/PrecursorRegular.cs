using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Modelos
{
    public class PrecursorRegular : Publicador
    {
        public DateTime FechaInicio { get; set; }

        public int Identificacion { get; set; }

        public int MetaMensual => 70;
    }
}
