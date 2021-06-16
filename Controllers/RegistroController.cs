using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Practica04.Models;

namespace Practica04.Controllers
{
     
    public class RegistroController : Controller
    {
 
     private readonly RegistroContext _context;

     public RegistroController(RegistroContext context)
     {
         _context = context;
     }
   
       public IActionResult Registros()
        {
             ViewBag.FormularioIngresos= _context.FormularioIngresos.Select(x => new SelectListItem(x.NombreUsuario,x.Id.ToString()));
            return View();
        }


        [HttpPost]


public IActionResult Registros(FormularioRegistro p) {
    if(ModelState.IsValid){
    _context.FormularioRegistros.Add(p);
     _context.SaveChanges();
     return RedirectToAction("Index","Home");
    }else {
        return View(p);
    }
    }
    }
}
// gg;
