﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models {
    public class Product : BaseEntity
   
        {


        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public string PictureUrl { get; set; }

        [ForeignKey("ProductTypeId")]
        public ProductType ProductType { get; set; }

        public int ProductTypeId { get; set; }

        [ForeignKey("ProductBrandId")]
        public ProductBrand ProductBrand { get; set; }

        public int ProductBrandId { get; set; }
    }
}
