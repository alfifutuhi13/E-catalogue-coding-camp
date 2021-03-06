using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controllers
{
    public class AuthenticationController : Controller
    {
        public IActionResult Index()
        {
            return View("Views/Authentication/Index.cshtml");
        }
        
        public IActionResult Register()
        {
            return View("Views/Authentication/Register.cshtml");
        }
        
        public IActionResult Forgot()
        {
            return View("Views/Authentication/Forgot.cshtml");
        }
        public IActionResult RegisterRole()
        {
            return View("Views/Authentication/RegisterRole.cshtml");
        }
        public IActionResult RegisterClient()
        {
            return View("Views/Authentication/RegisterClient.cshtml");
        }

        public IActionResult Reset()
        {
            if (Request.Query.ContainsKey("Token"))
            {
                var token = Request.Query["Token"].ToString();
                ViewData["Token"] = token;
                return View();
            }
            return NotFound();
        }

        [HttpPost]
        public string Login(LoginVM login)
        {
            var client = new HttpClient();
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(login), Encoding.UTF8, "application/json");
            var result = client.PostAsync("https://localhost:44321/api/Accounts/Login", stringContent).Result;
            var data = result.Content.ReadAsStringAsync().Result;
            //var token = JsonConvert.DeserializeObject(data).ToString();
            HttpContext.Session.SetString("JWToken", data);
            if (result.IsSuccessStatusCode)
            {
                var jwtReader = new JwtSecurityTokenHandler();
                var jwt = jwtReader.ReadJwtToken(data);

                var role = jwt.Claims.First(c => c.Type == "role").Value;
                if (role == "Candidate")
                {
                    return Url.Action("Candidate", "Home");
                }
                else if (role == "Client")
                {
                    return Url.Action("Client", "Home");
                }
                else
                {
                    return Url.Action("Admin", "Home");
                }
            }
            else
            {
                return "Error";
                //return BadRequest(new { result });
            }   

        }

        [HttpPost]
        public IActionResult ForgotPassword(ForgotPasswordVM forgotPassword)
        {
            var client = new HttpClient();
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(forgotPassword), Encoding.UTF8, "application/json");
            var result = client.PostAsync("https://localhost:44321/api/Accounts/Forgot-Password", stringContent).Result;
            if (result.IsSuccessStatusCode)
            {
                return Ok(new { result });
            }
            else
            {
                return BadRequest(new { result });
            }
        }

        [HttpPut]
        public IActionResult ResetPassword(ChangePasswordVM resetPassword)
        {
            var client = new HttpClient();
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(resetPassword), Encoding.UTF8, "application/json");
            var result = client.PutAsync("https://localhost:44321/api/Accounts/Reset-Password", stringContent).Result;
            if (result.IsSuccessStatusCode)
            {
                return Ok(new { result });
            }
            else
            {
                return BadRequest(new { result });
            }
        }

        [HttpPost]
        public string Register(RegisterVM registerVM)
        {
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(registerVM), Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync("https://localhost:44321/api/Accounts/register/", content);
            response.Wait();
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                return Url.Action("Index", "Authentication");
            }
            else
            {
                return "Error";
            }
        }
    }
}
