using System;
using System.Collections.Generic;
using System.Text;

namespace CandidateManagement.Data.Entities
{
    public class WorkExperience
    {
        public WorkExperience()
        {

        }
        public int WorkExperienceId { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public string Info { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}
