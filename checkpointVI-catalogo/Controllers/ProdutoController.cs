using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace checkpointVI_catalogo.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            var nomes = new List<string>
            {
                "Notebook Gamer",
                "Smartphone",
                "Headset",
                "Teclado Mecânico",
                "Monitor"
            };

            var precos = new List<decimal>
            {
                5599.90m,
                2499.00m,
                299.90m,
                429.50m,
                1299.99m
            };

            ViewBag.Nomes = nomes;
            ViewBag.Precos = precos;

            return View();
        }
    }
}
