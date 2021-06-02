using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("Views/Login/Login.cshtml");
        }
        
        public IActionResult Register()
        {
            return View("Views/Login/Register.cshtml");
        }
        
        public IActionResult Forgot()
        {
            return View("Views/Login/Forgot.cshtml");
        }


    }
}
