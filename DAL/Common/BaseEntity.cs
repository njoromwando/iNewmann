using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Common
{
   public class BaseEntity
    {
        public Guid Id { get; set; } 
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow.AddHours(3);
        public DateTime DateModified { get; set; } = DateTime.UtcNow.AddHours(3);

    }
}
