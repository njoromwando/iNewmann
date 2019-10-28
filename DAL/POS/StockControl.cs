using DAL.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.POS
{
    public  class StockControl : BaseEntity
    {
        [Key]
        public Int64 Recno { get; set; }
        public string ProductCode { get; set; }
        public string SupplierCode { get; set; }
        public decimal ProductIn { get; set; }
        public decimal ProductOut { get; set; }
        public string Narration { get; set; }
        public string InvoiceNo { get; set; }
        public string Docno { get; set; }
        public string Docid { get; set; }

    }
    // on invoice and invoice items creation we will update the stock table 
    // 

}
