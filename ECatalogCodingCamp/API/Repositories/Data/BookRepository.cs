using API.Context;
using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repositories.Data
{
    public class BookRepository : GeneralRepository<Book, MyContext, int>
    {
        private readonly MyContext myContext;

        public BookRepository(MyContext myContext) : base(myContext)
        {

        }
    }
}
