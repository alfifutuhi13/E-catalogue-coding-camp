using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModels
{
    public class InterviewRequestVM
    {
        public int CandidateId { get; set; }
        public long BidSalary { get; set; }
        public DateTime Schedule { get; set; }
        public string Message { get; set; }
    }
}
