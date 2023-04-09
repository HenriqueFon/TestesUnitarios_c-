using SistemaDeVendas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendas.Interface
{
    public interface ISistemasDeVenda
    {
        IList<Vendas> getVendas();
    }
}
