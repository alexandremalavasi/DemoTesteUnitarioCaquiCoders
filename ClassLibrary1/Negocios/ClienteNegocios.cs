using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Negocios
{
    public class ClienteNegocios
    {
        public static void Inserir(Cliente cliente)
        {
            if(String.IsNullOrWhiteSpace(cliente.Nome))
            {
                throw new NullReferenceException();
            }
        }

        public static double AplicarDesconto(Cliente cliente, double valor_compra)
        {
            //PARA CLIENTES OURO APLICAR 25% DE DESCONTO OURO
            if(cliente.Tipo == 1)
            {
                return valor_compra * 0.75;
            }
            //PARA CLIENTES PRATA APLICAR 10% DE DESCONTO PRATA

            if (cliente.Tipo == 2)
            {
                return valor_compra * 0.90;
            }

            if(cliente.Tipo == 3)
            {
                return valor_compra * 0.95;
            }



            

            return valor_compra;
        }
    }
}
