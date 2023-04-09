namespace testesUnitarios
{
    public class CalculadoraTest
    {
        //Fact, recebe um valor e devolve o resultado do teste
        //Theory, pode receber varios valores din�micos. � necess�rio passar um paramentro na fun��o
        //ex: int val1 e para passar o valor usamos o inlineData
        [Fact(DisplayName = "Deve calcular a soma de 1 + 1 e ser igual a 2")]
        public void TestSum()
        {
            Assert.Equal(2, Calculadora.Calculadora.sum(1, 1));
        }

        //Theory, pode receber varios valores din�micos. � necess�rio passar um paramentro na fun��o
        //ex: int val1 e para passar o valor usamos o inlineData para passar varios valores
        //Evita a cria��o de v�rias fun��es de teste, assim reaproveitando a mesma fun��o para diversos
        //valores
        [Theory(DisplayName = "Deve calcular a soma de v�rios n�meros")]
        [InlineData(0,1)]
        [InlineData(1, 1)]
        [InlineData(2, 1)]
        [InlineData(3, 1)]
        public void LotsTestSum(int val1, int val2)
        {
            Assert.Equal(1, Calculadora.Calculadora.sum(val1,val2));
        }
    }
}