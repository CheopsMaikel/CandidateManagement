using System;
using System.Collections.Generic;
using System.Text;

namespace CandidateManagement.Data.Entities
{
    public class Skill
    {
        public Skill()
        {
            Certificates = new List<Certificate>();
        }
        public int SkillId { get; set; }
        public string Technology { get; set; }
        public int YearsOfExpience { get; set; }
        public IEnumerable<Certificate> Certificates { get; set; }
    }
}
