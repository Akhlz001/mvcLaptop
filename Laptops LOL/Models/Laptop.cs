using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GamingLaptopWebsite.Models
{
    public class Laptop
    {
        [ScaffoldColumn(false)]
        public int ProductID { get; set; }

        public int LaptopID { get; set; }

        [StringLength(50), Required]

        public string Model { get; set; }

        [StringLength(50), Required]

        public string ScreenSize { get; set; }

        [StringLength(6)]

        public string ImagePath { get; set; }

        [StringLength(128), DataType(DataType.Url)]

        public string Description { get; set; }

        [Required, Range(500, 3000)]

        public decimal RamSize { get; set; }

        public decimal StorageSize { get; set; }

        public string OSVersion { get; set; }

        public decimal LaptopDimensions { get; set; }

        public string Price { get; set; }
    }
}