using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestePratico.Models;

namespace TestePratico.Controllers
{
    [RoutePrefix("api")]
    public class ProdutoController : ApiController
    {

        public static List<Produto> listaProdutos = new List<Produto>();
        public List<Produto> getLista()
        {
            return listaProdutos;
        }
        [System.Web.Http.AcceptVerbs("GET")]
        [System.Web.Http.Route("produto")]
        public List<Produto> ConsultarProdutos()
        {
            return listaProdutos;
        }
        [System.Web.Http.AcceptVerbs("POST")]
        [System.Web.Http.Route("produto")]
        public List<Produto> CadastroProdutos(Produto produto)
        {
            listaProdutos.Add(produto);
            return listaProdutos;
        }
        [System.Web.Http.AcceptVerbs("PUT")]
        [System.Web.Http.Route("alterarestoque")]
        public string AlterarEstoque(Produto produto)
        {
            if (listaProdutos.Exists(n => n.Codigo == produto.Codigo))
            {
                listaProdutos.Where(num => num.Codigo == produto.Codigo)
                         .Select(sel =>
                         {
                             sel.Estoque = produto.Estoque;
                             return sel;
                         }).ToList();
                return "Estoque alterado com sucesso";
            }
            else
            {
                return "Codigo inexistente";
            }
        }
        [System.Web.Http.AcceptVerbs("PUT")]
        [System.Web.Http.Route("alterapreco")]
        public string AlterarPreco(Produto produto)
        {
            if (listaProdutos.Exists(n => n.Codigo == produto.Codigo))
            {
                listaProdutos.Where(num => num.Codigo == produto.Codigo)
                         .Select(sel =>
                         {
                             sel.Preco = produto.Preco;
                             return sel;
                         }).ToList();
                return "Preco alterado com sucesso";
            }
            else
            {
                return "Codigo inexistente";
            }
        }
        [System.Web.Http.AcceptVerbs("DELETE")]
        [System.Web.Http.Route("produto")]
        public string ExcluirProduto(int Codigo)
        {
            if (listaProdutos.Exists(n => n.Codigo == Codigo))
            {
                Produto produto = listaProdutos.Where(num => num.Codigo == Codigo)
                                                .Select(sel => sel)
                                                .First();
                listaProdutos.Remove(produto);
                return "Produto excluido com sucesso";
            }
            else
            {
                return "Codigo inexistente";
            }
        }
    }
}
