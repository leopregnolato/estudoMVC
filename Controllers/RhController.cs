using Microsoft.AspNetCore.Mvc;
using System;

namespace estudoMVC.Controllers
{
    public class RhController : Controller
    {
        public IActionResult Index(){
            return View();
        }

        public IActionResult Endereco(){
            return View();
        }

        public IActionResult NovoEndereco(){
            return View();
        }
    }
}