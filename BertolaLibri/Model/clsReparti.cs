using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BertolaLibri.Model
{
    internal class clsReparti
    {
        private string pCodReparto;
        private string pDesReparto;
        private char pValReparto;

        public string CodReparto { get => pCodReparto; set => pCodReparto = value; }
        public string DesReparto { get => pDesReparto; set => pDesReparto = value; }
        public char ValReparto { get => pValReparto; set => pValReparto = value; }
    }
}
