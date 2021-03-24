using FundamentosOO.BibliotecaDeClasses.nsEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO.TipoGenerico
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Variáveis 
            int retorno = 0;
            int inteiroUm = 10;
            int inteiroDois = 20;
            string stringUm = "Juliano";
            string stringDois = "Fernand";
            #endregion Variáveis

            #region Trocar Inteiro
            Console.WriteLine("Valor variáveis inteiras antes de acionar o método Trocar");
            Console.WriteLine($"inteiroUm: {inteiroUm} inteiroDois: {inteiroDois}");
            Console.WriteLine();

            retorno = Trocar(ref inteiroUm, ref inteiroDois);

            if(retorno == -1)
            {
                Console.WriteLine("Erro ao acionar o metodo Trocar");
                return;
            }

            Console.WriteLine("Valor variáveis inteiras após acionar o método Trocar");
            Console.WriteLine($"inteiroUm: {inteiroUm} inteiroDois: {inteiroDois}");
            Console.WriteLine();
            #endregion Trocar Inteiro

            #region Trocar String
            Console.WriteLine();
            Console.WriteLine("Valor variáveis strings antes de acionar o método Trocar");
            Console.WriteLine($"stringUm: {stringUm} stringDois: {stringDois}");
            Console.WriteLine();

            Trocar(ref stringUm, ref stringDois);

            if (retorno == -1)
            {
                Console.WriteLine("Erro ao acionar o metodo Trocar");
                return;
            }

            Console.WriteLine("Valor variáveis strings após acionar o método Trocar");
            Console.WriteLine($"stringUm: {stringUm} stringDois: {stringDois}");
            Console.WriteLine();
            #endregion Trocar String

            #region Valor Máximo

            Console.WriteLine("Valor máximo comparando as variáveis inteiroUm e inteiroDois");
            Console.WriteLine($"Valor máximo inteiro {CompararMaiorValor(inteiroUm, inteiroDois)}");

            Console.WriteLine();

            Console.WriteLine("Valor máximo comparando as váriaveis stringUm e stringDois");
            Console.WriteLine($"Valor máximo string {CompararMaiorValor(stringUm, stringDois)}");

            Console.WriteLine();

            #endregion Valor Máximo

            #region Criar Lista

            //List<int> listaDeInteiros = new List<int>()
            //    {
            //        inteiroUm,
            //        inteiroDois,
            //    };

            GetLista(inteiroUm, inteiroDois, 50, 60, 70, 80).ForEach(x => { Console.WriteLine($"Inteiro: {x}"); });
            Console.WriteLine();
            GetLista(stringUm, stringDois).ForEach(x => { Console.WriteLine($"String: {x}"); });

            #endregion Criar Lista

            #region Classe Genérica

            var listaClasseGenerica = new ListaGenerica<string>();

            listaClasseGenerica.Add(stringUm);
            listaClasseGenerica.Add(stringDois);

            Console.WriteLine($"Meu registro na lista de classe genérica na posição 1 é:" +
                $" {listaClasseGenerica.GetItem(1)}");

            #endregion Classe Genérica

            Console.ReadLine();
        }

        #region Trocar

        private static int Trocar<T>(ref T parametroUm, ref T parametroDois)
        {
            try
            {
                T parametroTemporario = parametroUm;
                parametroUm = parametroDois;
                parametroDois = parametroTemporario;

                return 0;
            }
            catch
            {
                return -1;
            }
        }

        #endregion Trocar

        #region CompararMaiorValor

        /// <summary>Este é um exemplo de método de tipo genérico
        /// Onde definimos que o tipo genérico deve implementar a interface IComparable
        /// Outras restrições que podem ser utilizadas
        /// where T : class, indica que T deve ser um tipo de referência (classe)
        /// where T : struct, indica que T deve ser um tipo de valor (estrutura)
        /// where T : new(), obriga que T tenha um construtor público  sem parâmetros
        /// where T : NomeDaClasse, indica que T seja desse tipo de classe ou herde dela
        /// where T : INomeDaInterface, indica que T deve implementar a interface indicada
        /// </summary>
        private static T CompararMaiorValor<T>(T parametroValorUm, T parametroValorDois) where T : IComparable
            => parametroValorUm.CompareTo(parametroValorDois) > 0 ? parametroValorUm : parametroValorDois;

        #endregion CompararMaiorValor

        private static List<T> GetLista<T>(params T[] parametros)
        {
            var lista = new List<T>();

            foreach(T registro in parametros)
                lista.Add(registro);

            return lista;
        }
    }
}