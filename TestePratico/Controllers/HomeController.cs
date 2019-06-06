using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestePratico.Models;

namespace TestePratico.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ProdutoController pc = new ProdutoController();
            List<Produto> lista = pc.getLista();
            return View(lista);
        }
    }
}
