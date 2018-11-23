using System;
using System.Collections.Generic;
using System.Text;

namespace CandidateManagement.Data.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Box { get; set; }
    }
}
