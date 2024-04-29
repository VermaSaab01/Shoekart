using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Kart_Shopping_Model.ViewModels
{
   public class ProductVM
    {
        public Product Product { get; set; }
        public Category Category { get; set; }
        public ShoeSize ShoeSize { get; set; }
        public IEnumerable<SelectListItem> BrandList { get; set; }
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        public IEnumerable<SelectListItem> ShoeSizeList { get; set; }
        private GenderType _gender;



        public GenderType GenderType

        {

            get { return _gender; }

            set { _gender = value; }

        }
        /*public GenderType GenderType { get; set; }*/
    }
}
