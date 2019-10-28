﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.POS
{
    public class ProductCategory
    {
        [Key]
        public int Recno { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime  DateCreated { get; set; }
    }
}
