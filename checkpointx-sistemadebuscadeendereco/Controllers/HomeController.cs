using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using checkpointx_sistemadebuscadeendereco.Models;

namespace checkpointx_sistemadebuscadeendereco.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View(new Endereco());
    }

    [HttpPost]
    public IActionResult Enviar(Endereco endereco)
    {
        if (!ModelState.IsValid)
        {
            return View("Index", endereco);
        }

        TempData["Endereco"] = JsonSerializer.Serialize(endereco);
        return RedirectToAction(nameof(Resumo));
    }

    public IActionResult Resumo()
    {
        if (TempData["Endereco"] is string enderecoJson)
        {
            var endereco = JsonSerializer.Deserialize<Endereco>(enderecoJson);
            if (endereco != null)
            {
                return View(endereco);
            }
        }

        return RedirectToAction(nameof(Index));
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
