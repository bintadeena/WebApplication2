﻿using System.ComponentModel.DataAnnotations;

namespace WingtipToys.Models
{
    public class Product
    {
        [ScaffoldColumn(false)]
        public int ProductID { get; set; }

        [Required, StringLength(10000), Display(AutoGenerateField = true, Name = "Product Description"), DataType(DataType.MultilineText)]
        public string ProductName { get; set; }

        public string ImagePath { get; set; }
        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}