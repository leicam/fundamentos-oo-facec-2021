using FundamentosOO.BibliotecaDeClasses.nsEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO.Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            var pedido1 = new PedidoVenda("Juliano", "Juarez", "Rua Caravelas, 991, Jussara - PR", 100.60m);

            #region Implementação convencional

            ImprimirPedido(pedido1.NomeCliente, pedido1.NomeVendedor, pedido1.ValorTotal);

            #endregion Implementação convencional

            #region Parâmetros nomeados

            ImprimirPedido(vendedor: pedido1.NomeVendedor, valorTotal: pedido1.ValorTotal, cliente: pedido1.NomeCliente);
            ImprimirPedido(valorTotal: pedido1.ValorTotal, vendedor: pedido1.NomeVendedor, cliente: pedido1.NomeCliente);

            #endregion Parâmetros nomeados

            #region Parâmetro opcional

            ImprimirPedidoComParametrosOpcionais(pedido1.NomeCliente, pedido1.ValorTotal);
            ImprimirPedidoComParametrosOpcionais(pedido1.NomeCliente, pedido1.ValorTotal, pedido1.NomeVendedor);

            #endregion Parâmetro opcional

            #region Sobrecargas

            ImprimirPedido(pedido1.NomeCliente, pedido1.NomeVendedor, pedido1.Endereco, pedido1.ValorTotal);
            Console.WriteLine(ImprimirPedido(pedido1));
            Console.WriteLine(pedido1.ToString());

            #endregion Sobrecargas

            Console.ReadLine();
        }

        internal static void ImprimirPedido(string cliente, string vendedor, decimal valorTotal)
        {
            Console.WriteLine($"Cliente: {cliente} Vendedor: {vendedor} Total R$: {valorTotal}");
        }

        internal static void ImprimirPedido(string cliente, string vendedor, string endereco, decimal valorTotal)
        {
            Console.WriteLine($"Cliente: {cliente} Vendedor: {vendedor} Endereço: {endereco} Total R$: {valorTotal}");
        }

        internal static string ImprimirPedido(PedidoVenda pedidoVenda)
        {
            return $"Cliente: {pedidoVenda.NomeCliente} Vendedor: {pedidoVenda.NomeVendedor}" +
                $" Endereço: {pedidoVenda.Endereco} Total R$: {pedidoVenda.ValorTotal}";
        }

        internal static void ImprimirPedidoComParametrosOpcionais(string cliente, decimal valorTotal, string vendedor = "")
        {
            if (string.IsNullOrWhiteSpace(vendedor))
                Console.WriteLine($"Cliente: {cliente} Total R$: {valorTotal}");
            else
                Console.WriteLine($"Cliente: {cliente} Vendedor: {vendedor} Total R$: {valorTotal}");
        }
    }
}