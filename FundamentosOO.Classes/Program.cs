using FundamentosOO.BibliotecaDeClasses.nsEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var posicaoGPS1 = new PosicaoGPS(15.35m, 53.72m);
            //var posicaoGPS2 = new AbstractPosicaoGPS();
            var posicaoGPS3 = new PosicaoGPSComDataLeitura(27.55m, 33.79m);

            //posicaoGPS1.Latitude = 16.15m;

            //Console.WriteLine(posicaoGPS1.ToString());
            //Console.WriteLine($"Posição GPS está no hemisfério norte? {posicaoGPS1.IsHemisferioNorte}");
            //Console.WriteLine($"Posição GPS está no hemisfério sul? {posicaoGPS1.IsHemisferioSul}");
            Console.WriteLine(posicaoGPS3.ToString());
            Console.ReadLine();
        }
    }
}