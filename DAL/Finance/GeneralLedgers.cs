using DAL.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Finance
{
   public class GeneralLedgers : DoubleEntry
    {
        [Key]
        public Int64 Recno { get; set; }
        public string AccountNumber { get; set; }
        public string Folio { get; set; }

    }
}
