using DAL.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.POS
{
  public  class Product 
    {
        [Key]
        public string Code { get; set; }
        public string CategoryCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public decimal SellPrice { get; set; }
        public decimal Vat { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }
    }

    public class ProductCategory
    {
        [Key]
        public string Code { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime  DateCreated { get; set; }
    }

    public class VATCalculate
    {
        public string Code { get; set; }
        public string ProductCode { get; set; }    
        public decimal Rate { get; set; }

    }
}
