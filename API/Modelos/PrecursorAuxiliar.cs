using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Modelos
{
    public class PrecursorAuxiliar
    {
        public bool MetaReducida { get; set; }

        public int MetaMensual => MetaReducida ? 30 : 50;

        public List<Mes> Mes { get; set; }

        public bool Indefinido { get; set; }
    }
}
