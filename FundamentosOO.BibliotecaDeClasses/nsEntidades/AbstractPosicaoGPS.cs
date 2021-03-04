using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO.BibliotecaDeClasses.nsEntidades
{
    public abstract class AbstractPosicaoGPS
    {
        public decimal Latitude { get; private set; } = 0.0m;
        public decimal Longitude { get; private set; } = 0.0m;
        public bool IsHemisferioNorte => Latitude > 0;
        public bool IsHemisferioSul => Latitude < 0;

        public AbstractPosicaoGPS(decimal latitude, decimal longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public override string ToString() => $"Latitude: {Latitude} Longitude:{Longitude}";
    }
}