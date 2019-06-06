using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestePratico.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Estoque { get; set; }
        public decimal Preco { get; set; }

        public Produto() { }

        public Produto(int cod, string nome, int estoque, decimal preco)
        {
            this.Codigo = cod;
            this.Nome = nome;
            this.Estoque = estoque;
            this.Preco = preco;
        }
    }
}