using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using checkpointVIII_FORMULARIO_CADASTRO_ALUNO.Models;

namespace checkpointVIII_FORMULARIO_CADASTRO_ALUNO.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return RedirectToAction("Cadastrar", "Aluno");
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
