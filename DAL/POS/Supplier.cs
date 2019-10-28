using DAL.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.POS
{
    // Suppliers will supply the goods
    public class Supplier : BaseEntity
    {
        [Key]
        public Int32 Recno { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Bank { get; set; }
        public string BankBranch { get; set; }
        public  string BankAccountNo { get; set; }
        public string BankAccountname { get; set; }
        public string AccountNumber { get; set; }

    }
    // on invoice and invoice items creation we will update the stock table 
    // 

}
