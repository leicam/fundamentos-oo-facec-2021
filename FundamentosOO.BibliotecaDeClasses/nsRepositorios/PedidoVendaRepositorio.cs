using FundamentosOO.BibliotecaDeClasses.nsEntidades;
using FundamentosOO.BibliotecaDeClasses.nsInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosOO.BibliotecaDeClasses.nsRepositorios
{
    public class PedidoVendaRepositorio : IPedidoVendaRepository
    {
        private readonly List<PedidoVenda> _lista = new List<PedidoVenda>();

        public void AdicionarPedido(PedidoVenda pedidoVenda)
        {
            _lista.Add(pedidoVenda);
        }

        public void AlterarPedido(PedidoVenda pedidoVenda)
        {
            var pedido = GetPedidoVenda(pedidoVenda.Id);

            RemoverPedido(pedido);
            AdicionarPedido(pedidoVenda);
        }

        public PedidoVenda GetPedidoVenda(Guid guid)
            => _lista.FirstOrDefault(x => x.Id == guid) ?? throw new Exception("Pedido de Venda não encontrado");
        //{
        //    PedidoVenda pedido = null;

        //    foreach (var registro in _lista)
        //    {
        //        if (registro.Id == guid)
        //        {
        //            pedido = registro;
        //            break;
        //        }
        //    }

        //    if (pedido == null)
        //        throw new Exception("Pedido de Venda não encontrado");

        //    return pedido;
        //}

        public List<PedidoVenda> GetTodosOsPedidos()
        {
            return _lista;
        }

        public void RemoverPedido(PedidoVenda pedidoVenda)
        {
            _lista.Remove(pedidoVenda);
        }
    }
}