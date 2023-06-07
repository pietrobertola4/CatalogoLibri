using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BertolaLibri.Model
{
    internal class clsEditori
    {
        private int pCodEditore;
        private string pNomeEditore;
        private char pValEditore;

        public int CodEditore { get => pCodEditore; set => pCodEditore = value; }
        public string NomeEditore { get => pNomeEditore; set => pNomeEditore = value; }
        public char ValEditore { get => pValEditore; set => pValEditore = value; }
    }
}
