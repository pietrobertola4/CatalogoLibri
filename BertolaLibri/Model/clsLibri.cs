using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BertolaLibri.Model
{
    internal class clsLibri
    {
        private int pCodLibro;
        private string pTitoloLibro;
        private double pPrezzoLibro;
        private DateTime pDataLibro;
        private int pNPagLibro;
        private string pCodRepLibro;
        private int pCodOffLibro;
        private int pCodEdiLibro;
        private char pValLibro;

        public int CodLibro { get => pCodLibro; set => pCodLibro = value; }
        public string TitoloLibro { get => pTitoloLibro; set => pTitoloLibro = value; }
        public double PrezzoLibro { get => pPrezzoLibro; set => pPrezzoLibro = value; }
        public DateTime DataLibro { get => pDataLibro; set => pDataLibro = value; }
        public int NPagLibro { get => pNPagLibro; set => pNPagLibro = value; }
        public string CodRepLibro { get => pCodRepLibro; set => pCodRepLibro = value; }
        public int CodOffLibro { get => pCodOffLibro; set => pCodOffLibro = value; }
        public int CodEdiLibro { get => pCodEdiLibro; set => pCodEdiLibro = value; }
        public char ValLibro { get => pValLibro; set => pValLibro = value; }
    }
}
