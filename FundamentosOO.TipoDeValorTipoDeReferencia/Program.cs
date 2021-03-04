using FundamentosOO.BibliotecaDeClasses.nsEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO.TipoDeValorTipoDeReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tipo de Valor

            int inteiro1 = 10;
            int inteiro2 = inteiro1;
            inteiro1 = 5;

            //int inteiro3 = null;
            Nullable<int> inteiro4 = null;
            int? inteiro5 = null;
            string string1 = null;

            //Console.WriteLine($"Inteiro 1: {inteiro1}");
            //Console.WriteLine($"Inteiro 2: {inteiro2}");
            //Console.ReadLine();

            #endregion Tipo de Valor

            #region Tipo de Referencia

            PosicaoGPS posicaoGPS1;
            PosicaoGPS posicaoGPS2;
            PosicaoGPS posicaoGPS3;

            posicaoGPS1 = new PosicaoGPS(-10.33m, 65.39m);
            posicaoGPS2 = posicaoGPS1;
            posicaoGPS3 = new PosicaoGPS(56.99m, 33.78m);

            posicaoGPS1.SetLatitude(-20.44m);

            Console.WriteLine(posicaoGPS1.ToString());
            Console.WriteLine(posicaoGPS2.ToString());
            Console.WriteLine(posicaoGPS3.ToString());

            #endregion Tipo de Referencia
        }
    }
}