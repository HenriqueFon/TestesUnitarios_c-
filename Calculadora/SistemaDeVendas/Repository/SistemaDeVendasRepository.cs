using SistemaDeVendas.Interface;
using SistemaDeVendas.Model;

namespace SistemaDeVendas.Repository
{
    public class SistemaDeVendasRepository : ISistemasDeVenda
    {
        public IList<Vendas> getVendas()
        {
            return new List<Vendas>
            {
                new Vendas
                {
                    id = 1,
                    name = "Gabinete",
                    price = 120,
                    stock = 1
                },
                new Vendas
                {
                    id = 2,
                    name = "Mouse",
                    price = 124,
                    stock = 2
                }
            };
        }

    }
}