using CandidateManagement.Data.Entities;
using System;
using System.Collections.Generic;

namespace CandidateManagement.Data.Entities
{
    public class Candidate
    {
        public Candidate()
        {
            //PreferedCompanies = new List<Company>();
            //Technologies = new List<Technology>();
        }
        public int CandidateId { get; set; }
        public string SurName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string MobilePhone { get; set; }
        public byte[] CV { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public DateTime DateJobApplication { get; set; }
        public DateTime DateFirstTakeIn { get; set; }
        public bool HasDriverLicense { get; set; }
        public int? AddressId { get; set; }
        public Address Address { get; set; }
        public int? RoleId { get; set; }
        public Role Role { get; set; }
        public int? CurrentSalaryId { get; set; }
        public Salary CurrentSalary { get; set; }
        public int? ProposedSalaryId { get; set; }
        public Salary ProposedSalary { get; set; }
        //public IEnumerable<Company> PreferedCompanies { get; set; }
        //public IEnumerable<Technology> Technologies { get; set; }
    }
}
