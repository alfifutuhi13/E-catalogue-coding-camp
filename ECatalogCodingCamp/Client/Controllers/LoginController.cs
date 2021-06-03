using API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
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
        
        public IActionResult Reset()
        {
            return View("Views/Login/Reset.cshtml");
        }

        [HttpPost]
        public HttpStatusCode Register(RegisterVM registerVM)
        {
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(registerVM), Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync("https://localhost:44321/api/Accounts/register/", content);
            response.Wait();
            var result = response.Result;
            return result.StatusCode;
        }
        [HttpPut]
        public HttpStatusCode ForgotPassword(ForgotPasswordVM forgotPasswordVM)
        {
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(forgotPasswordVM), Encoding.UTF8, "application/json");
            var result = httpClient.PutAsync("https://localhost:44321/api/Accounts/forgot-password/", content).Result;
            return result.StatusCode;
        }
    }
}
