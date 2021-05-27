using API.Context;
using API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class UserRepository : GeneralRepository<User, MyContext, int>
    {
        private readonly MyContext myContext;

        public UserRepository(MyContext myContext) : base(myContext)
        {
            
        }
    }
}
