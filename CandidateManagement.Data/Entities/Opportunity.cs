using System;
using System.Collections.Generic;
using System.Text;

namespace CandidateManagement.Data.Entities
{
    public class Opportunity
    {
        public int OpportunityId { get; set; }
        public string GeneralTitle { get; set; }
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public string Description { get; set; }

    }
}
