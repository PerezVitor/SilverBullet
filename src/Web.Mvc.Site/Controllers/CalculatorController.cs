using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Web.Mvc.Site.Models;

namespace Web.Mvc.Site.Controllers;
public class CalculatorController : Controller
{
    public IActionResult Index() => View();

    public void Operacao(string teste)
    {
        _ = teste;
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}