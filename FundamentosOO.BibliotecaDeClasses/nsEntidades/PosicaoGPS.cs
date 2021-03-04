using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO.BibliotecaDeClasses.nsEntidades
{
    public class PosicaoGPS : AbstractPosicaoGPS
    {
        public PosicaoGPS(decimal latitude, decimal longitude) : base(latitude, longitude) { }

        //public bool IsHemisferioNorte() => Latitude > 0;
        //public bool IsHemisferioSul() => Latitude < 0;
    }
}