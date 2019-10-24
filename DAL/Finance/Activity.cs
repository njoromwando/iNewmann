using DAL.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Finance
{
   public class Activity: BaseEntity
    {
        public string Code { get; set; }
        public string Description { get; set; }

    }
}
