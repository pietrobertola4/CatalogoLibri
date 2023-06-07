using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BertolaLibri.Model
{
    internal class clsOfferte
    {
        private int pCodOfferta;
        private string pDesOfferta;
        private int pScontoOfferta;
        private char pValOfferta;

        public int CodOfferta { get => pCodOfferta; set => pCodOfferta = value; }
        public string DesOfferta { get => pDesOfferta; set => pDesOfferta = value; }
        public int ScontoOfferta { get => pScontoOfferta; set => pScontoOfferta = value; }
        public char ValOfferta { get => pValOfferta; set => pValOfferta = value; }
    }
}
