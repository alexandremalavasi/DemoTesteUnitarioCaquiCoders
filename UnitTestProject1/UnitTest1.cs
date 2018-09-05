using System;
using Xunit;


namespace UnitTestProject1
{
    public class UnitTest1
    {
        //[Fact]
        public void TesteNomeNulo()
        {
            ClassLibrary1.Pessoa pessoa = new ClassLibrary1.Pessoa();

            Action act = () => pessoa.Inserir(pessoa);
            Assert.Throws<NullReferenceException>(act);

        }

        //[Fact]
        public void TesteRegraDescontoPlanoGold()
        {
            ClassLibrary1.Pessoa pessoa = new ClassLibrary1.Pessoa();

            pessoa.Tipo = 0;

            double desconto =  pessoa.AplicaDesconto(pessoa, 100);

            Assert.Equal(75,desconto);

            

        }
    }
}
