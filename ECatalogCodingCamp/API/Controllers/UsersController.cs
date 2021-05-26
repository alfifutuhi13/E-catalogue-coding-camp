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
    public class UsersController BaseController<User, UserRepository, int>
    {
        private readonly UserRepository userRepository;
    public UserController(UserRepository userRepository) : base(userRepository)
    {
        this.userRepository = userRepository;
    }
}
}
