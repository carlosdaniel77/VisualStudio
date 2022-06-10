using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RsMotores.WEB.Controllers
{
    public class CasaController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Titulo = "Index tipo string";
            ViewBag.Id = 1;
            ViewBag.Obj = new String("Oi");
            return View();
        }

        public IActionResult VerCasa()
        {
            ViewBag.Titulo = "Ver Casa"; //Recebe tipo de dados e relaciona seu tipo dinamicamente
            ViewData["Titulo"] = 10;
            
            return View();
        }
    }
}
