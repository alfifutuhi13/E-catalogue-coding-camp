using API.Context;
using API.Repositories.Data;
using API.ViewModels;
using Client.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly CandidateRepository candidateRepository;
        private readonly MyContext myContext = new MyContext();
        List<CandidatesVM> candidates = new List<CandidatesVM>();
        HttpClientHandler clientHandler = new HttpClientHandler();

        public HomeController(ILogger<HomeController> logger, CandidateRepository candidateRepository, MyContext myContext)
        {
            this.myContext = myContext;
            _logger = logger;
            this.candidateRepository = candidateRepository;
        }

        public IActionResult Index()
        {
            var token = HttpContext.Session.GetString("JWToken");
            if (token != null)
            {
                var jwtReader = new JwtSecurityTokenHandler();
                var jwt = jwtReader.ReadJwtToken(token);
                var role = jwt.Claims.First(c => c.Type == "role").Value;
                var email = jwt.Claims.First(c => c.Type == "email").Value;
                var foundUser = myContext.Users.FirstOrDefault(user => user.Email == email);

                return View();

            }
            else
            {
                return RedirectToAction("Index", "Authentication");
            }
        }

        public IActionResult Candidate()
        {
            var token = HttpContext.Session.GetString("JWToken");
            if(token != null)
            {
                var jwtReader = new JwtSecurityTokenHandler();
                var jwt = jwtReader.ReadJwtToken(token);
                var role = jwt.Claims.First(c => c.Type == "role").Value;
                var email = jwt.Claims.First(c => c.Type == "email").Value;
                var foundUser = myContext.Users.FirstOrDefault(user => user.Email == email);
                ViewData["name"] = foundUser.Name;
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Authentication");
            }
        }

        public IActionResult Client()
        {
            var token = HttpContext.Session.GetString("JWToken");
            if (token != null)
            {
                var jwtReader = new JwtSecurityTokenHandler();
                var jwt = jwtReader.ReadJwtToken(token);
                var role = jwt.Claims.First(c => c.Type == "role").Value;
                var email = jwt.Claims.First(c => c.Type == "email").Value;
                var foundUser = myContext.Users.FirstOrDefault(user => user.Email == email);
                ViewData["name"] = foundUser.Name;
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Authentication");
            }
        }

        public IActionResult Admin()
        {
            var token = HttpContext.Session.GetString("JWToken");
            if (token != null)
            {
                var jwtReader = new JwtSecurityTokenHandler();
                var jwt = jwtReader.ReadJwtToken(token);
                var role = jwt.Claims.First(c => c.Type == "role").Value;
                var email = jwt.Claims.First(c => c.Type == "email").Value;
                var foundUser = myContext.Users.FirstOrDefault(user => user.Email == email);
                ViewData["name"] = foundUser.Name;
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Authentication");
            }
        }

        public HttpStatusCode ChangePassword(ChangePasswordVM changePasswordVM)
        {
            changePasswordVM.Token = HttpContext.Session.GetString("JWToken");
            var httpClient = new HttpClient();
            StringContent content = new StringContent(JsonConvert.SerializeObject(changePasswordVM), Encoding.UTF8, "application/json");
            var result = httpClient.PutAsync("https://localhost:44321/api/Accounts/Change-Password", content).Result;
            return result.StatusCode;
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("JWToken");
            return RedirectToAction("Index", "Authentication");
        }

        [HttpGet]
        public async Task<List<CandidatesVM>> GetAllCandidates()
        {
            candidates = new List<CandidatesVM>();
            using (var httpClient = new HttpClient(clientHandler))
            {
                using (var response = httpClient.GetAsync("https://localhost:44321/api/Candidates/GetCandidates").Result)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    candidates = JsonConvert.DeserializeObject<List<CandidatesVM>>(apiResponse);
                }
            }
            return candidates;
        }

        [HttpGet]
        public JsonResult GetById(int id)
        {
            var client = new HttpClient();
            var response = client.GetAsync("https://localhost:44321/api/users/" + id);
            response.Wait();
            var result = response.Result;
            var apiResponse = result.Content.ReadAsStringAsync();

            return Json(apiResponse.Result);
        }

        [HttpPost]
        public HttpStatusCode InterviewRequest(InterviewRequestVM interviewRequest)
        {
            var token = HttpContext.Session.GetString("JWToken");
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(interviewRequest), Encoding.UTF8, "application/json");
            var response = client.PostAsync("https://localhost:44321/api/InterviewRequests/Interview-Request", stringContent );
            response.Wait();
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                return HttpStatusCode.OK;
            }
            //var apiResponse = result.Content.ReadAsStringAsync();

            return HttpStatusCode.BadRequest;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
