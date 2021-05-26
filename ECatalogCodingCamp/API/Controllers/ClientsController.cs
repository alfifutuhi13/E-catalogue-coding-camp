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
    public class ClientsController : BaseController<Client, ClientRepository, int>
    {
        private readonly ClientRepository clientRepository;
        public ClientController(ClientRepository clientRepository) : base(clientRepository)
        {
            this.clientRepository = clientRepository;
        }
    }
}
