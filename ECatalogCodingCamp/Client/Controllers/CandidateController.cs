using API.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controllers
{
    public class CandidateController : Controller
    {
        private readonly API.Context.MyContext context;
        public CandidateController(API.Context.MyContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Education()
        {
            var token = HttpContext.Session.GetString("JWToken");
            if (token != null)
            {
                var jwtReader = new JwtSecurityTokenHandler();
                var jwt = jwtReader.ReadJwtToken(token);
                var role = jwt.Claims.First(c => c.Type == "role").Value;
                var email = jwt.Claims.First(c => c.Type == "email").Value;
                var foundUser = context.Users.FirstOrDefault(user => user.Email == email);
                ViewData["name"] = foundUser.Name;
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Authentication");
            }
        }
        public IActionResult CV()
        {
            var token = HttpContext.Session.GetString("JWToken");
            if (token != null)
            {
                var jwtReader = new JwtSecurityTokenHandler();
                var jwt = jwtReader.ReadJwtToken(token);
                var role = jwt.Claims.First(c => c.Type == "role").Value;
                var email = jwt.Claims.First(c => c.Type == "email").Value;
                var foundUser = context.Users.FirstOrDefault(user => user.Email == email);
                ViewData["name"] = foundUser.Name;
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Authentication");
            }
        }

        public IActionResult Organization() 
        {
            var token = HttpContext.Session.GetString("JWToken");
            if (token != null)
            {
                var jwtReader = new JwtSecurityTokenHandler();
                var jwt = jwtReader.ReadJwtToken(token);
                var role = jwt.Claims.First(c => c.Type == "role").Value;
                var email = jwt.Claims.First(c => c.Type == "email").Value;
                var foundUser = context.Users.FirstOrDefault(user => user.Email == email);
                ViewData["name"] = foundUser.Name;
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Authentication");
            }
        }

        public IActionResult Skill() 
        {
            var token = HttpContext.Session.GetString("JWToken");
            if (token != null)
            {
                var jwtReader = new JwtSecurityTokenHandler();
                var jwt = jwtReader.ReadJwtToken(token);
                var role = jwt.Claims.First(c => c.Type == "role").Value;
                var email = jwt.Claims.First(c => c.Type == "email").Value;
                var foundUser = context.Users.FirstOrDefault(user => user.Email == email);
                ViewData["name"] = foundUser.Name;
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Authentication");
            }
        }

        public IActionResult Work() 
        {
            var token = HttpContext.Session.GetString("JWToken");
            if (token != null)
            {
                var jwtReader = new JwtSecurityTokenHandler();
                var jwt = jwtReader.ReadJwtToken(token);
                var role = jwt.Claims.First(c => c.Type == "role").Value;
                var email = jwt.Claims.First(c => c.Type == "email").Value;
                var foundUser = context.Users.FirstOrDefault(user => user.Email == email);
                ViewData["name"] = foundUser.Name;
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Authentication");
            }
        }

        public IActionResult Profile()
        {
            return View();
        }
        public IActionResult Biodata()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertEducation(EducationVM educationVM)
        {
            var httpClient = new HttpClient();

            var token = HttpContext.Session.GetString("JWToken");
            var jwtReader = new JwtSecurityTokenHandler();
            var jwt = jwtReader.ReadJwtToken(token);
            var role = jwt.Claims.First(c => c.Type == "role").Value;
            var email = jwt.Claims.First(c => c.Type == "email").Value;

            educationVM.Role = role;
            educationVM.Email = email;

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            StringContent content = new StringContent(JsonConvert.SerializeObject(educationVM), Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync("https://localhost:44321/api/Educations/insert-education/", content);
            response.Wait();
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                var strObject = new
                {
                    Result = result,
                    Email = email,
                    Role = role
                };

                return Ok(strObject);
            }
            else
            {
                //return "Error";
                return BadRequest(new { result = result, Message = "Can't Insert Education data."  });
            }
        }

        [HttpPost]
        public ActionResult InsertCV(InsertCVVM cv)
        {
            var httpClient = new HttpClient();

            var token = HttpContext.Session.GetString("JWToken");
            var jwtReader = new JwtSecurityTokenHandler();
            var jwt = jwtReader.ReadJwtToken(token);
            var role = jwt.Claims.First(c => c.Type == "role").Value;
            var email = jwt.Claims.First(c => c.Type == "email").Value;

            cv.Role = role;
            cv.Email = email;

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            StringContent content = new StringContent(JsonConvert.SerializeObject(cv), Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync("https://localhost:44321/api/CVs/insertcv/", content);
            response.Wait();
            var result = response.Result;
            if (result.IsSuccessStatusCode)
            {
                var strObject = new
                {
                    Result = result,
                    Email = email,
                    Role = role
                };

                return Ok(strObject);
            }
            else
            {
                //return "Error";
                return BadRequest(new { result = result, Message = "Can't Insert Education data." });
            }
        }

        [HttpGet]
        public string GetEduId()
        {
            var httpClient = new HttpClient();
            var token = HttpContext.Session.GetString("JWToken");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = httpClient.GetAsync("https://localhost:44321/api/Educations/GetAllData").Result;
            var apiResponse = response.Content.ReadAsStringAsync();
            apiResponse.Wait();
            return apiResponse.Result;
        }

        [HttpPut]
        public HttpStatusCode UpdateEducation(EducationVM education)
        {
            var httpClient = new HttpClient();

            var token = HttpContext.Session.GetString("JWToken");
            var jwtReader = new JwtSecurityTokenHandler();
            var jwt = jwtReader.ReadJwtToken(token);
            var role = jwt.Claims.First(c => c.Type == "role").Value;
            var email = jwt.Claims.First(c => c.Type == "email").Value;

            education.Role = role;
            education.Email = email;

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            StringContent content = new StringContent(JsonConvert.SerializeObject(education), Encoding.UTF8, "application/json");
            var response = httpClient.PutAsync("https://localhost:44321/api/Educations/update-education/", content);
            response.Wait();
            var result = response.Result;
            return result.StatusCode;
        }

        [HttpGet]
        public string GetCVId()
        {
            var httpClient = new HttpClient();
            var token = HttpContext.Session.GetString("JWToken");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = httpClient.GetAsync("https://localhost:44321/api/CVs/Experience").Result;
            var apiResponse = response.Content.ReadAsStringAsync();
            apiResponse.Wait();
            return apiResponse.Result;

        }

        [HttpPut]
        public HttpStatusCode UpdateCV(InsertCVVM cv)
        {
            var httpClient = new HttpClient();

            var token = HttpContext.Session.GetString("JWToken");
            var jwtReader = new JwtSecurityTokenHandler();
            var jwt = jwtReader.ReadJwtToken(token);
            var role = jwt.Claims.First(c => c.Type == "role").Value;
            var email = jwt.Claims.First(c => c.Type == "email").Value;

            cv.Role = role;
            cv.Email = email;

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            StringContent content = new StringContent(JsonConvert.SerializeObject(cv), Encoding.UTF8, "application/json");
            var response = httpClient.PutAsync("https://localhost:44321/api/CVs/updatecv/", content);
            response.Wait();
            var result = response.Result;
            return result.StatusCode;
        }

        [HttpGet]
        public string GetOrganizationId()
        {
            var httpClient = new HttpClient();
            var token = HttpContext.Session.GetString("JWToken");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = httpClient.GetAsync("https://localhost:44321/api/Organizations/OrganizationData").Result;
            var apiResponse = response.Content.ReadAsStringAsync();
            apiResponse.Wait();
            return apiResponse.Result;

        }

        [HttpPost]
        public HttpStatusCode InsertOrganization(InsertCVVM cv)
        {
            var httpClient = new HttpClient();

            var token = HttpContext.Session.GetString("JWToken");
            var jwtReader = new JwtSecurityTokenHandler();
            var jwt = jwtReader.ReadJwtToken(token);
            var role = jwt.Claims.First(c => c.Type == "role").Value;
            var email = jwt.Claims.First(c => c.Type == "email").Value;

            cv.Role = role;
            cv.Email = email;

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            StringContent content = new StringContent(JsonConvert.SerializeObject(cv), Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync("https://localhost:44321/api/Organizations/InsertOrganization/", content);
            response.Wait();
            var result = response.Result;
            return result.StatusCode;
        }
        [HttpPut]
        public HttpStatusCode UpdateOrganization(InsertCVVM cv)
        {
            var httpClient = new HttpClient();

            var token = HttpContext.Session.GetString("JWToken");
            var jwtReader = new JwtSecurityTokenHandler();
            var jwt = jwtReader.ReadJwtToken(token);
            var role = jwt.Claims.First(c => c.Type == "role").Value;
            var email = jwt.Claims.First(c => c.Type == "email").Value;

            cv.Role = role;
            cv.Email = email;

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            StringContent content = new StringContent(JsonConvert.SerializeObject(cv), Encoding.UTF8, "application/json");
            var response = httpClient.PutAsync("https://localhost:44321/api/Organizations/UpdateOrganization/", content);
            response.Wait();
            var result = response.Result;
            return result.StatusCode;
        }

        [HttpGet]
        public string GetSkillId()
        {
            var httpClient = new HttpClient();
            var token = HttpContext.Session.GetString("JWToken");

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = httpClient.GetAsync("https://localhost:44321/api/Skillss/SkillData").Result;
            var apiResponse = response.Content.ReadAsStringAsync();
            apiResponse.Wait();
            return apiResponse.Result;

        }
    }
}