using System;
using System.Collections.Generic;
using System.Text;

namespace CandidateManagement.Data.Entities
{
    public class JobApplication
    {
        public int JobApplicationId { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public Opportunity Opportunity { get; set; }
    }
}
