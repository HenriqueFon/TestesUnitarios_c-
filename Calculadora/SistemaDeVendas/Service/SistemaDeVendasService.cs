using SistemaDeVendas.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendas.Service
{
    public class SistemaDeVendasService
    {
        private readonly ISistemasDeVenda _vendas;

        public SistemaDeVendasService(ISistemasDeVenda vendas)
        {
            _vendas = vendas;
        }

        public int verificaEstoque(string produto)
        {
            var vendas = _vendas.getVendas();

            var estoque = vendas
                .Where(p => p.name == produto)
                .Select(r => r.stock);

            return estoque.First();
        }

        public int verificaValor(string produto)
        {
            var vendas = _vendas.getVendas();

            var preco = vendas
                .Where(p => p.name == produto)
                .Select(r => r.price);

            return preco.First();
        }
    }
}
