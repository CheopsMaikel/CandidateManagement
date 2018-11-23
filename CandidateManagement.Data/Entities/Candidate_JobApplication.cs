using CandidateManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CandidateManagement.Data.Entities
{
    public class Candidate_JobApplication
    {
        public int Candidate_JobApplicationId { get; set; }

        public Candidate Candidate { get; set; }

        public JobApplication JobApplication { get; set; }
    }
}
