using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO.BibliotecaDeClasses.nsEntidades
{
    public class PosicaoGPSComDataLeitura : AbstractPosicaoGPS
    {
        public DateTime DataLeitura { get; private set; }

        public PosicaoGPSComDataLeitura(decimal latitude, decimal longitude) : base(latitude, longitude)
        {
            DataLeitura = DateTime.Now;
        }

        public override string ToString() => $"{base.ToString()} Data de Leitura: {DataLeitura}";
    }
}