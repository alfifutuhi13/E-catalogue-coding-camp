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
            return View();
        }
        public IActionResult CV()
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
            var jwtReader = new JwtSecurityTokenHandler();
            var jwt = jwtReader.ReadJwtToken(token);
            var email = jwt.Claims.First(c => c.Type == "email").Value;

            var Candidate = context.Users.FirstOrDefault(c => c.Email == email);
            //EducationVM educationVM = new EducationVM();
            //educationVM.Email = email;

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            //StringContent content = new StringContent(JsonConvert.SerializeObject(educationVM), Encoding.UTF8, "application/json");
            //var responseAll = httpClient.PostAsync("https://localhost:44321/api/Educations/GetAllData", content).Result;
            //var apiResponseAll = responseAll.Content.ReadAsStringAsync();
            //apiResponseAll.Wait();
            var response = httpClient.GetAsync("https://localhost:44321/api/Educations/" + Candidate.Id).Result;
            var apiResponse = response.Content.ReadAsStringAsync();
            apiResponse.Wait();
            return apiResponse.Result;
        }
        [HttpGet]
        public string GetCVId()
        {
            InsertCVVM cv = new InsertCVVM();
            var httpClient = new HttpClient();
            var token = HttpContext.Session.GetString("JWToken");
            var jwtReader = new JwtSecurityTokenHandler();
            var jwt = jwtReader.ReadJwtToken(token);
            var email = jwt.Claims.First(c => c.Type == "email").Value;
            cv.Email = email;
            var Candidate = context.Users.FirstOrDefault(c => c.Email == email);

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            StringContent content = new StringContent(JsonConvert.SerializeObject(cv), Encoding.UTF8, "application/json");
            var response = httpClient.PostAsync("https://localhost:44321/api/CVs/Experience", content).Result;
            var apiResponse = response.Content.ReadAsStringAsync();
            apiResponse.Wait();
            return apiResponse.Result;

        }
    }
}
