using Microsoft.AspNetCore.Mvc;
using MvcRazorViews.ViewModels;

namespace MvcRazorViews.Controllers;

public class EstudanteController : Controller
{
    private static List<EstudanteViewModel> estudantes = new List<EstudanteViewModel>{
        new EstudanteViewModel(1, "Maria", "R. Ma. n.1", true),
        new EstudanteViewModel(2, "Pedro", "R. Pe. n.2", false),
        new EstudanteViewModel(3, "Marta", "R. Ma. n.3", true)
    };
    public IActionResult Index()
    {
        //var EstudantesVazia = new List<EstudanteViewModel>();
        //return EstudantesVazia;
        return View(estudantes);
    }

    public IActionResult Show(int id)
    {
        return View(estudantes[id-1]);
    }
}