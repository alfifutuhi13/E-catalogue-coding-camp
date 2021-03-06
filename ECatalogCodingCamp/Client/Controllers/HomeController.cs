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
        readonly HttpClient client = new HttpClient
        {
            BaseAddress = new Uri("https://localhost:44321/API/")
        };

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
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", changePasswordVM.Token);
            StringContent content = new StringContent(JsonConvert.SerializeObject(changePasswordVM), Encoding.UTF8, "application/json");
            var result = httpClient.PutAsync("https://localhost:44321/api/Accounts/Change-Password", content).Result;
            return result.StatusCode;
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult ProfileClient()
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

        public IActionResult ProfileCandidate()
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

        [HttpGet]
        public string GetUserId()
        {
            var httpClient = new HttpClient();
            var token = HttpContext.Session.GetString("JWToken");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = httpClient.GetAsync("https://localhost:44321/api/Users/GetUser").Result;
            var apiResponse = response.Content.ReadAsStringAsync();
            apiResponse.Wait();
            return apiResponse.Result;
        }

        //[HttpGet("Candidate/Home/GetDetail")]
        public JsonResult GetDetail(int id)
        {
            var httpClient = new HttpClient();
            var token = HttpContext.Session.GetString("JWToken");
            //var candidateId = HttpContext.Session.GetInt32("CandidateID");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = client.GetAsync($"Users/Detail/{id}");
            var result = response.Result;
            var apiResponse = result.Content.ReadAsStringAsync();
            apiResponse.Wait();
            return Json(apiResponse.Result);
        }

        public string GetDetailCV(int id)
        {
            var httpClient = new HttpClient();
            var token = HttpContext.Session.GetString("JWToken");
            //var candidateId = HttpContext.Session.GetInt32("CandidateID");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = client.GetAsync($"Users/DetailCV/{id}");
            var result = response.Result;
            var apiResponse = result.Content.ReadAsStringAsync();
            apiResponse.Wait();
            return apiResponse.Result;
        }

        [HttpGet]
        public string GetCandidateId()
        {
            var httpClient = new HttpClient();
            var token = HttpContext.Session.GetString("JWToken");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = httpClient.GetAsync("https://localhost:44321/api/Books/GetCandidate").Result;
            var apiResponse = response.Content.ReadAsStringAsync();
            apiResponse.Wait();
            return apiResponse.Result;
        }


        [HttpGet]
        public string GetClientId()
        {
            var httpClient = new HttpClient();
            var token = HttpContext.Session.GetString("JWToken");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = httpClient.GetAsync("https://localhost:44321/api/Books/GetClientId").Result;
            var apiResponse = response.Content.ReadAsStringAsync();
            apiResponse.Wait();
            return apiResponse.Result;
        }

        [HttpPut]
        public HttpStatusCode UpdateProfile(ProfileVM profile)
        {
            var httpClient = new HttpClient();

            var token = HttpContext.Session.GetString("JWToken");
            var jwtReader = new JwtSecurityTokenHandler();
            var jwt = jwtReader.ReadJwtToken(token);
            var email = jwt.Claims.First(c => c.Type == "email").Value;

            profile.Email = email;

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            StringContent content = new StringContent(JsonConvert.SerializeObject(profile), Encoding.UTF8, "application/json");
            var response = httpClient.PutAsync("https://localhost:44321/api/Users/Update-Profile/", content);
            response.Wait();
            var result = response.Result;
            return result.StatusCode;
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

        [HttpGet]
        public JsonResult GetBookById(int id)
        {
            var client = new HttpClient();
            var token = HttpContext.Session.GetString("JWToken");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = client.GetAsync("https://localhost:44321/api/books/GetInterviewRequest/" + id);
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

        [HttpPut]
        public HttpStatusCode UpdateInterviewRequest(InterviewRequestVM interviewRequest)
        {
            var token = HttpContext.Session.GetString("JWToken");
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(interviewRequest), Encoding.UTF8, "application/json");
            var response = client.PutAsync("https://localhost:44321/api/Books/Response-Interview-Request", stringContent);
            response.Wait();
            var result = response.Result;
            return result.StatusCode;
        }

        [HttpGet]
        public HttpStatusCode SendConfirm(int id)
        {
            var token = HttpContext.Session.GetString("JWToken");
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = client.GetAsync("https://localhost:44321/api/Books/SendConfirm/" + id);
            response.Wait();
            var result = response.Result;
            return result.StatusCode;
        }

        public IActionResult InterviewCandidate()
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


        public IActionResult InterviewClient()
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

        //[HttpGet]
        //public HttpStatusCode GetClient(int id)
        //{
        //    var token = HttpContext.Session.GetString("JWToken");
        //    var client = new HttpClient();
        //    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        //    var response = client.GetAsync($"https://localhost:44321/api/Books/GetClient/{id}");
        //    response.Wait();
        //    var result = response.Result;
        //    if (result.IsSuccessStatusCode)
        //    {
        //        return HttpStatusCode.OK;
        //    }
        //    //var apiResponse = result.Content.ReadAsStringAsync();

        //    return HttpStatusCode.BadRequest;
        //}

        [HttpGet]
        public string GetClient(int id)
        {
            var token = HttpContext.Session.GetString("JWToken");
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = client.GetAsync("https://localhost:44321/api/Books/GetClient/" + id);
            response.Wait();
            var result = response.Result;
            var apiResponse = result.Content.ReadAsStringAsync();

            return apiResponse.Result;
        }

        [HttpGet]
        public string GetCandidate(int id)
        {
            var token = HttpContext.Session.GetString("JWToken");
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = client.GetAsync("https://localhost:44321/api/Books/GetCandidate/" + id);
            response.Wait();
            var result = response.Result;
            var apiResponse = result.Content.ReadAsStringAsync();

            return apiResponse.Result;
        }

        [HttpDelete]
        public string Accepted(int id)
        {
            var token = HttpContext.Session.GetString("JWToken");
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = client.DeleteAsync("https://localhost:44321/api/Books/Accepted/" + id);
            response.Wait();
            var result = response.Result;
            var apiResponse = result.Content.ReadAsStringAsync();

            return apiResponse.Result;
        }

        [HttpDelete]
        public string Rejected(int id)
        {
            var token = HttpContext.Session.GetString("JWToken");
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = client.DeleteAsync("https://localhost:44321/api/Books/Rejected/" + id);
            response.Wait();
            var result = response.Result;
            var apiResponse = result.Content.ReadAsStringAsync();

            return apiResponse.Result;
        }

        [HttpGet]
        public string Reschedule(int id)
        {
            var token = HttpContext.Session.GetString("JWToken");
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = client.GetAsync("https://localhost:44321/api/Books/Reschedule/" + id);
            response.Wait();
            var result = response.Result;
            var apiResponse = result.Content.ReadAsStringAsync();

            return apiResponse.Result;
        }

        [HttpPut]
        public HttpStatusCode UpdateInterviewRequestClient(InterviewRequestVM interviewRequest)
        {
            var token = HttpContext.Session.GetString("JWToken");
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            StringContent stringContent = new StringContent(JsonConvert.SerializeObject(interviewRequest), Encoding.UTF8, "application/json");
            var response = client.PutAsync("https://localhost:44321/api/Books/UpdateInterviewRequestClient", stringContent);
            response.Wait();
            var result = response.Result;
            return result.StatusCode;
        }

        public IActionResult Details()
        {
            var token = HttpContext.Session.GetString("JWToken");
            var candidateId = HttpContext.Session.GetInt32("CandidateID");
            if (token != null)
            {
                var jwtReader = new JwtSecurityTokenHandler();
                var jwt = jwtReader.ReadJwtToken(token);
                var role = jwt.Claims.First(c => c.Type == "role").Value;
                var email = jwt.Claims.First(c => c.Type == "email").Value;
                var foundUser = myContext.Users.FirstOrDefault(user => user.Email == email);
                ViewData["name"] = foundUser.Name;
                ViewData["candidateId"] = candidateId;
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Authentication");
            }
        }

        [HttpGet]
        public string GoDetails(int id)
        {
            HttpContext.Session.SetInt32("CandidateID", id);
            return Url.Action("Details", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
