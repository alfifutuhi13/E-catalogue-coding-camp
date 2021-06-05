using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Client.ViewModels
{
    public class ClientVM
    {
        public Candidate Candidates { get; set; }
        public string PageTitle { get; set; }
    }
}
