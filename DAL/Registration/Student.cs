using DAL.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Registration
{
  public  class Student : Person
    {
        public string StudentNo { get; set; }
        public string DateOfAdmission { get; set; }
        public string Class { get; set; }
        public string Stream { get; set; }
    }
}
