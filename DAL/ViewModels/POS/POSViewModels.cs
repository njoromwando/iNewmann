using DAL.POS;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.ViewModels.POS
{
  public  class POSViewModels
    {
        public class ProductViewModels
        {
          
            public string Code { get; set; }
            public string CategoryCode { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Unit { get; set; }
            public decimal Price { get; set; }
            public decimal SellPrice { get; set; }
            public decimal Vat { get; set; }
            public string ImageUrl { get; set; }
            public string CreatedBy { get; set; }
            public DateTime DateCreated { get; set; }
        }

        public class SupplierViewModel
        {                 
            public string Code { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string Bank { get; set; }
            public string BankBranch { get; set; }
            public string BankAccountNo { get; set; }
            public string BankAccountname { get; set; }
            public string AccountNumber { get; set; }

        }

        public class CaptureItems
        {
            public string SupplierCode { get; set; }
            public string ProductCode { get; set; }
            public decimal  Count { get; set; }
            public string InvoiceNo { get; set; }

        }
    }
}
