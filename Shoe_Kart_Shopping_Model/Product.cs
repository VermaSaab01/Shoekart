using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Kart_Shopping_Model
{
   public class Product
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Serial Number")]
        public string SerialNo { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Range(1,10000)]
        public double ListPrice { get; set; }
        [Required]
        [Range(1,10000)]
        public double Price50 { get; set; }
        [Required]
        [Range(1, 10000)]
        public double Price { get; set; }
        [Display(Name = "Image URL")]
        public string ImageURL { get; set; }
        public GenderType Gender { get; set; }
        [Display(Name = "Brand")]
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }
        [Display(Name = "Category")]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
        [Display(Name = "Shoe Size")]
        public int ShoeSizeId { get; set; }
        [ForeignKey("ShoeSizeId")]
        public ShoeSize ShoeSize { get; set; }
    }
}
