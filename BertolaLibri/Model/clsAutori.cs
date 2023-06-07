using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BertolaLibri.Model
{
    internal class clsAutori
    {
        private int pCodAutore;
        private string pCognAutore;
        private string pNomeAutore;
        private DateTime pDataNasAutore;
        private char pValAutore;

        public int CodAutore { get => pCodAutore; set => pCodAutore = value; }
        public string CognAutore { get => pCognAutore; set => pCognAutore = value; }

        public string NomeAutore { get => pNomeAutore; set => pNomeAutore = value; }
        public DateTime DataNasAutore { get => pDataNasAutore; set => pDataNasAutore = value; }

        public char ValAutore { get => pValAutore; set => pValAutore = value; }
    }
}
