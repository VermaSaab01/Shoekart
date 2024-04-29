using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Kart_Shopping_Model
{
   public class ShoppingCart
    {
        public ShoppingCart()
        {
            Count = 1;
        }
        public int Id { get; set; }
        public string ApplicationUserId { get; set; }
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser ApplicationUser { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        public int Count { get; set; }
        [NotMapped]
        public double Price { get; set; }
        [Display(Name ="Shoe Size")]
        public int ShoeSizeSelectorId { get; set; }
        [ForeignKey("ShoeSizeSelectorId")]
        public ShoeSizeSelector ShoeSizeSelector { get; set; }
    }
}
