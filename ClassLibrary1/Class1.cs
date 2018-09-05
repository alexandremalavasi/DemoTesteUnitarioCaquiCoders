using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Tipo { get; set; }

        public void Inserir(Pessoa pessoa)
        {
            if(pessoa.Nome == null)
            {
                throw new NullReferenceException();
            }
        }

        public double AplicaDesconto(Pessoa pessoa, double valor_compra)
        {
            if(pessoa.Tipo == 1)
            {
                return valor_compra * 0.75;
            }
            else
            {
                return valor_compra;
            }
        }
    }
}
