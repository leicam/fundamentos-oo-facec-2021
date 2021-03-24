using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO.BibliotecaDeClasses.nsEntidades
{
    public class PedidoVenda
    {
        public Guid Id { get; private set; }
        public string NomeCliente { get; private set; }
        public string NomeVendedor { get; private set; }
        public string Endereco { get; private set; }
        public decimal ValorTotal { get; private set; }

        public PedidoVenda(string nomeCliente, string nomeVendedor, string endereco, decimal valorTotal)
        {
            Id = Guid.NewGuid();
            NomeCliente = nomeCliente;
            NomeVendedor = nomeVendedor;
            Endereco = endereco;
            ValorTotal = valorTotal;
        }

        public override string ToString() 
            => $"Id: {Id} Cliente: {NomeCliente} Vendedor: {NomeVendedor} Endereço: {Endereco} Total R$: {ValorTotal}";
    }
}