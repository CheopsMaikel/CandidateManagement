using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidateManagement.Application.Dtos
{
    public sealed class CandidateDto
    {
        public string SurName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        //public byte[] CV { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime DateJobApplication { get; set; }
        public DateTime DateFirstTakeIn { get; set; }
        public bool HasDriverLicense { get; set; }
    }
}
