using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Kart_Shopping_Model
{
   public class Brand
    {
        public int id { get; set; }
        [Required]
        [Display(Name ="Brand Name")]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
