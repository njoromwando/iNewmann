using DAL.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Registration
{
   public  class GuardianOrKin : Person
    {
        public string IdentificationNo { get; set; }
        public string DocumentType { get; set; }
        public string ImageURL { get; set; }
        public string Relationship { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }

    }
}
