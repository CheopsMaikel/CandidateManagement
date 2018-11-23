using System;
using System.Collections.Generic;
using System.Text;

namespace CandidateManagement.Data.Entities
{
    public class WorkExperience_Technology
    {
        public int WorkExperience_TechnologyId { get; set; }
        public WorkExperience WorkExperience { get; set; }
        public Technology Technology { get; set; }
    }
}
