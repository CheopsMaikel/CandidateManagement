using System;
using System.Collections.Generic;
using System.Text;

namespace CandidateManagement.Data.Entities
{
    public class JobApplication_Meeting
    {
        public int JobApplication_MeetingId { get; set; }
        public JobApplication JobApplication { get; set; }
        public Meeting Meeting { get; set; }
    }
}
