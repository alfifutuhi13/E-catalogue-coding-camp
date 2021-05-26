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
    public class BooksController : BaseController<Book, BookRepository, int>
    {
        private readonly BookRepository bookRepository;
        public BookController(BookRepository bookRepository) : base(bookRepository)
        {
            this.bookRepository = bookRepository;
        }
    }
}
