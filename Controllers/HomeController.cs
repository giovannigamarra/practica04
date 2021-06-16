using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Practica04.Models;
namespace Practica04.Controllers
{
    public class HomeController : Controller
    {
       private readonly RegistroContext _context;

     public HomeController(RegistroContext context)
     {
         _context = context;
     }

        public IActionResult Index()
        {
            var formularioRegistros = _context.FormularioRegistros.Include(x => x.FormularioIngreso).Where(x => x.FechaRegistro.AddDays(5) >= DateTime.Now).ToList();
            return View(formularioRegistros);
        }
// gg;
     

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
