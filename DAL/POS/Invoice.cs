using DAL.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.POS
{
    // Items supplied will be have an invoice
    public class Invoice : BaseEntity
    {
        [Key]
        public Int32 Recno { get; set; }
        public string InvoiceNo { get; set; }
        public string SupplierCode { get; set; }
        public string Total { get; set; }
        public DateTime InvoiceDate { get; set; }
    }
    // on invoice and invoice items creation we will update the stock table 
    // 

}
