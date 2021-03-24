using FundamentosOO.BibliotecaDeClasses.nsEntidades;
using FundamentosOO.BibliotecaDeClasses.nsInterfaces;
using FundamentosOO.BibliotecaDeClasses.nsRepositorios;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            IPedidoVendaRepository repository = new PedidoVendaRepositorio();
            var pedido1 = new PedidoVenda("Juliano", "Maycon", "Rua Teste, 103", 100.60m);

            repository.AdicionarPedido(pedido1);
            var pedidoConsultado = repository.GetPedidoVenda(pedido1.Id);

            Console.WriteLine(pedidoConsultado.ToString());
            Console.Write($"{DateTime.Now.ToString("ddMMyyyyHHmmss")}.xml");
            File.WriteAllText("C:\\VirtualPDV", $"{DateTime.Now}.xml");
            Console.ReadLine();
        }
    }
}