using FundamentosOO.BibliotecaDeClasses.nsEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO.BibliotecaDeClasses.nsInterfaces
{
    public interface IPedidoVendaRepository
    {
        void AdicionarPedido(PedidoVenda pedidoVenda);
        void AlterarPedido(PedidoVenda pedidoVenda);
        List<PedidoVenda> GetTodosOsPedidos();
        PedidoVenda GetPedidoVenda(Guid guid);
        void RemoverPedido(PedidoVenda pedidoVenda);
    }
}