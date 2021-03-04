using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO.Estrutura
{
    class Program
    {
        static void Main(string[] args)
        {
            var posicaoGPS1 = new PosicaoGPS(10, -15);

            //Console.WriteLine($"Latitude: {posicaoGPS1.Latitude}");
            //Console.WriteLine($"Longitude: {posicaoGPS1.Longitude}");
            Console.WriteLine(posicaoGPS1.ToString());
            Console.WriteLine($"Está no hemisfério norte? {posicaoGPS1.IsHemisferioNorte()}");
            Console.ReadLine();
        }
    }

    /// <summary>Este é um exemplo de struct
    /// Não pode ser abstrata
    /// Não pode ser static
    /// Não pode ser private
    /// Aceita apenas um construtor vazio ou construtores com parametros
    /// Pode sobreescrever metodos base
    /// </summary>
    internal struct PosicaoGPS
    {
        public decimal Latitude { get; private set; }
        public decimal Longitude { get; private set; }

        //public PosicaoGPS(decimal latitude) 
        //{ 
        //    Latitude = latitude;
        //    Longitude = 0;
        //}
        
        //public PosicaoGPS(decimal longitude) 
        //{ 
        //    Latitude = 0;
        //    Longitude = longitude;
        //}

        public PosicaoGPS(decimal latitude, decimal longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public bool IsHemisferioNorte()
        {
            return Latitude > 0;
        }

        public override string ToString()
        {
            return $"Latitude: {Latitude} \nLongitude: {Longitude}";
        }
    }
}