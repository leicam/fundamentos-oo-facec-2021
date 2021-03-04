using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO.Enumeracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            var segunda = DiasDaSemana.Segunda;
            var diasUteis = DiasDaSemana.Segunda
                | DiasDaSemana.Terca
                | DiasDaSemana.Quarta
                | DiasDaSemana.Quinta
                | DiasDaSemana.Sexta;
            var diaFolga = DiasDaSemana.Sabado | DiasDaSemana.Domingo;

            //Console.WriteLine((int)segunda);
            //Console.WriteLine((byte)diasUteis);
            Console.WriteLine(segunda.GetDescription());

            Console.ReadLine();
        }
    }

    [Flags]
    internal enum DiasDaSemana : int
    {
        [Description("Segunda-Feira")]
        Segunda = 1,

        [Description("Terça-Feira")]
        Terca = 2,

        [Description("Quarta-Feira")]
        Quarta = 4,

        [Description("Quinta-Feira")]
        Quinta = 8,

        [Description("Sexta-Feira")]
        Sexta = 16,

        [Description("Sábado")]
        Sabado = 32,

        [Description("Domingo")]
        Domingo = 64,
    }

    public static class EnumExtensions
    {
        public static string GetDescription(this Enum e)
        {
            try
            {
                var fieldInfo = e.GetType().GetField(e.ToString());
                var arrayAtributtes = fieldInfo.GetCustomAttributes(false);

                if (arrayAtributtes.Length <= 0)
                    return string.Empty;

                var attribute = arrayAtributtes[0] as DescriptionAttribute;

                return attribute != null ? attribute.Description : string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }
    }
}