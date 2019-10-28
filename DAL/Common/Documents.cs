using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Common
{
   public class Documents
    {
        [Key]
        public int Recno { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
    }
}
