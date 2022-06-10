using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



    namespace RsMotores.WEB.Controllers
{
    public class LoginController : Controller
{
    public IActionResult Token()
{
    ViewBag.Sistema = "RSMotores";
    return View();
}
}
}