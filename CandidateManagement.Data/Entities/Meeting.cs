using System;
using System.Collections.Generic;
using System.Text;

namespace CandidateManagement.Data.Entities
{
    public class Meeting
    {
        public int MeetingId { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }//Personal, Technical
        public string NameInterviewer { get; set; }
        public string Notes { get; set; }
    }
}
