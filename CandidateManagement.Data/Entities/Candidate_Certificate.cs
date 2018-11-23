using CandidateManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CandidateManagement.Data.Entities
{
    public class Candidate_Certificate
    {
        public int Candidate_CertificateId { get; set; }

        public Candidate Candidate { get; set; }

        public Certificate Certificate { get; set; }
    }
}
