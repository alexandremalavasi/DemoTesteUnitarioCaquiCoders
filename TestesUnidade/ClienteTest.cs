using System;
using Xunit;
using ClassLibrary1;

namespace TestesUnidade
{
    public class ClientTest
    {

        public Cliente cliente;

        public ClientTest()
        {
            cliente = new Cliente();
        }

        [Fact]
        public void TesteInserirClienteComNomeNulo()
        {
            
            cliente.Nome = null;

            Action act = () => ClassLibrary1.Negocios.ClienteNegocios.Inserir(cliente);

            Assert.Throws<NullReferenceException>(act);

        }

        [Fact]
        public void TesteInserirClienteComNomeVazio()
        {
            
            cliente.Nome = " ";

            Action act = () => ClassLibrary1.Negocios.ClienteNegocios.Inserir(cliente);

            Assert.Throws<NullReferenceException>(act);

        }

        [Fact]
        public void TesteAplica25PorcentoDescontoOuro()
        {
            
            cliente.Tipo = 1;

            double desconto = ClassLibrary1.Negocios.ClienteNegocios.AplicarDesconto(cliente, 100);

            Assert.Equal(75, desconto);
        }

        [Fact]
        public void TesteAplica10PorcentoDescontoPrata()
        {
            
            cliente.Tipo = 2;

            double desconto = ClassLibrary1.Negocios.ClienteNegocios.AplicarDesconto(cliente, 100);

            Assert.Equal(90, desconto);
        }

        [Fact]
        public void TesteAplica5PorcentoDescontoBronze()
        {
            cliente.Tipo = 3;

            double desconto = ClassLibrary1.Negocios.ClienteNegocios.AplicarDesconto(cliente, 100);

            Assert.Equal(95, desconto);
        }
    }
}
