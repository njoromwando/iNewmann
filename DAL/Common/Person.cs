using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Common
{
  public  class Person : BaseEntity
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }


    }
}
