using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Kart_Shopping_Model.ViewModels
{
    public class ShoeVM
    {
        public ShoppingCart ShoppingCart { get; set; }
        public IEnumerable <SelectListItem>ShoeSizeList { get; set; }
        public ShoeSizeSelector ShoeSizeSelector { get; set; }
    }
}
