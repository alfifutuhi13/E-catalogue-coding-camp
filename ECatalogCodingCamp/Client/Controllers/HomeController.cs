using API.Context;
using API.Repositories.Data;
using API.ViewModels;
using Client.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
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
            return View();
        }

        public IActionResult Candidate()
        {
            return View();
        }

        public ViewResult Client()
        {
            var model = candidateRepository.GetAll();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
