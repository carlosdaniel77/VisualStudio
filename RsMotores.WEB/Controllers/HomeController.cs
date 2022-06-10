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
            ErrorMessage erroDados;
            var userDados = new Usuario()
            {
                cpf = "1232312312",
                email = "admin@admin",
                nome = "Admin",
                password = "123456"
            };

            ViewBag.Title = "Mensagem de Login";
            if (string.IsNullOrEmpty(email)&&
                string.IsNullOrEmpty(password))
            {
                erroDados = new ErrorMessage(3);
                ViewBag.Icon = "error";
                ViewBag.Msg= erroDados.msg;
                ViewBag.Color = "Red";
                return View("Error", erroDados);
            }
            else
            {
                if (email.Equals(userDados.email) && 
                    password.Equals(userDados.password))
                {
                    ViewBag.Icon = "sucess";
                    ViewBag.Msg = "Logado com sucesso";
                    ViewBag.Color = "Green";
                    return View(userDados);
                }
                else
                {
                    erroDados = new ErrorMessage(1);
                    ViewBag.Icon = "error";
                    ViewBag.Msg = erroDados.msg;
                    ViewBag.Color = "Red";
                    return View("Error", erroDados);
                }

            }
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
