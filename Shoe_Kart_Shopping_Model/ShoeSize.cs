using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Kart_Shopping_Model
{
   public class ShoeSize
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Size")]
        public string Name { get; set; }
    }
}
