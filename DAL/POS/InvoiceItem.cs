using DAL.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.POS
{
    // invoice will have a breakdown of various items
    public class InvoiceItem : BaseEntity
    {
        [Key]
        public Int64 Recno { get; set; }
        public string InvoiceNo { get; set; }
        public string ProductCode { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }

    }
    // on invoice and invoice items creation we will update the stock table 
    // 

}
