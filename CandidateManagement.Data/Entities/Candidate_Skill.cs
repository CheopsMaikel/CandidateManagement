using CandidateManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CandidateManagement.Data.Entities
{
    public class Candidate_Skill
    {
        public int Candidate_SkillId { get; set; }
        public Candidate Candidate { get; set; }
        public Skill Skill { get; set; }
    }
}
