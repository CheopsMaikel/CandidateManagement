using CandidateManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CandidateManagement.Data.Entities
{
    public class Candidate_WorkExperience
    {
        public int Candidate_WorkExperienceId { get; set; }

        public Candidate Candidate { get; set; }

        public WorkExperience WorkExperience { get; set; }
    }
}
