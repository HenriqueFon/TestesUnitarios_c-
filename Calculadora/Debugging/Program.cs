using SistemaDeVendas.Repository;
using SistemaDeVendas.Service;

namespace Debugging
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var valor = new SistemaDeVendasService(new SistemaDeVendasRepository()).verificaValor("Mouse");
            Console.WriteLine("Valor:" + valor);
        }
    }
}