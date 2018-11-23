using CandidateManagement.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CandidateManagement.Data
{
    public class CandidateContext : DbContext
    {
        public CandidateContext(DbContextOptions options)
        {

        }
        public DbSet<Address> Address { get; set; }
        public DbSet<Candidate> Candidate { get; set; }
        public DbSet<Candidate_Certificate> Candidate_Certificate { get; set; }
        public DbSet<Candidate_Skill> Candidate_Skill { get; set; }
        public DbSet<Candidate_WorkExperience> Candidate_WorkExperience { get; set; }
        public DbSet<Certificate> Certificate { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<CompanyCar> CompanyCar { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Salary> Salary { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<Technology> Technology { get; set; }
        public DbSet<WorkExperience> WorkExperience { get; set; }
        public DbSet<WorkExperience_Technology> WorkExperience_Technology { get; set; }
        public DbSet<Meeting> Meeting { get; set; }
        public DbSet<Candidate_JobApplication> Candidate_JobApplication { get; set; }
        public DbSet<Opportunity> Opportunity { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer("Server=850G5-MGE\\SQLEXPRESS01;Database=CandidateManagement;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);     
        }

    }
}
