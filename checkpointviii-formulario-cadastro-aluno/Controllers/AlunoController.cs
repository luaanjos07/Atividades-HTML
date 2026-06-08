using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using checkpointVIII_FORMULARIO_CADASTRO_ALUNO.Models;

namespace checkpointVIII_FORMULARIO_CADASTRO_ALUNO.Controllers;

public class AlunoController : Controller
{
    [HttpGet]
    public IActionResult Cadastrar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Cadastrar(Aluno aluno)
    {
        if (!ModelState.IsValid)
        {
            return View(aluno);
        }

        TempData["Aluno"] = JsonSerializer.Serialize(aluno);
        return RedirectToAction(nameof(Resumo));
    }

    [HttpGet]
    public IActionResult Resumo()
    {
        if (TempData["Aluno"] is string alunoJson)
        {
            var aluno = JsonSerializer.Deserialize<Aluno>(alunoJson);
            if (aluno != null)
            {
                return View(aluno);
            }
        }

        return RedirectToAction(nameof(Cadastrar));
    }
}
