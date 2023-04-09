using Moq;
using SistemaDeVendas.Interface;
using SistemaDeVendas.Model;
using SistemaDeVendas.Service;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;


namespace testesUnitarios
{
    public class SistemaDeVendasTest
    {
        SistemaDeVendasService sistemaDeVendas;
        Mock<ISistemasDeVenda> _vendas;

        public SistemaDeVendasTest()
        {
            // Definir uma lista de vendas para colocar dentro do objeto de mocking
            var retorno = new List<Vendas>
            {
                new Vendas{
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

            _vendas = new Mock<ISistemasDeVenda>();
            //eu faço um setup, ou seja, eu defino que meu mocking da função getVendas vinda de repository
            //que simula uma busca de dados em um banco de dados. Precisamos simular valores já que a chamada da função getVendas mesmo tendo sido definida
            //retornará nenhum valor. Por isso definimos uma lista acima na variável valor para fazer o set de valores.
            _vendas.Setup(x => x.getVendas()).Returns(retorno);

            //defino que minha instancia do Service do sistemas de vendas tem os valores que foram definidos na instância da classe de mocking 
            sistemaDeVendas = new SistemaDeVendasService(_vendas.Object);
        }

        [Fact(DisplayName = "Deve verificar o valor de um produto")]
        public void verificarValorProduto()
        {
            Assert.Equal(124, sistemaDeVendas.verificaValor("Mouse"));
        }

        [Fact(DisplayName = "Deve verificar o estoque de um produto")]
        public void verificarEstoqueProduto()
        {
            Assert.Equal(2, sistemaDeVendas.verificaEstoque("Mouse"));
        }
    }
}
