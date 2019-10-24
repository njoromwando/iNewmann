using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Common
{
  public  class DoubleEntry : BaseEntity
    {
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public string Narration { get; set; }
        public string Docid { get; set; }
        public string Docno { get; set; }
    }
}
