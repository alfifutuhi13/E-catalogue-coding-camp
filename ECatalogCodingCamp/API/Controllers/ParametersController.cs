using API.Base;
using API.Models;
using API.Repositories.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParametersController : BaseController<Parameter, ParameterRepository, int>
    {
        private readonly ParameterRepository parameterRepository;
        public ParametersController(ParameterRepository parameterRepository) : base(parameterRepository)
        {
            this.parameterRepository = parameterRepository;
        }
    }
}
