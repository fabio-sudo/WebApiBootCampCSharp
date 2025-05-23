using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Model
{
    public class Venda
    {

        //construtor
        public Venda(int id, string produto, decimal preco)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
        }



        //Atributos do objeto
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set;}
    }
}
