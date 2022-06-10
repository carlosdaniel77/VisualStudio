using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RsMotores.WEB.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace RsMotores.WEB.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /*
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        */
        [HttpPost]
        public IActionResult Index(string email, string password)
        {
            ViewBag.Title = "Mensagem de Login";
            if (string.IsNullOrEmpty(email)&&string.IsNullOrEmpty(password))
            {
                ViewBag.Icon = "error";
                ViewBag.Msg= "Campos: Emails e senhas não pode ser vazios";
                ViewBag.Color = "Red";
            }
            else
            {
                if (email.Equals("admin@admin") && password.Equals("123456"))
                {
                    ViewBag.Icon = "sucess";
                    ViewBag.Msg = "Logado com sucesso";
                    ViewBag.Color = "Green";
                }
                else
                {
                    ViewBag.Icon = "error";
                    ViewBag.Msg = "Email ou senha inválidos";
                    ViewBag.Color = "Red";
                }
            }
            return View();
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
}
