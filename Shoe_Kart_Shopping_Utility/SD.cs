using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Kart_Shopping_Utility
{
   public class SD
    {
        public const string Proc_product = "productdata";

        //roles
        public const string Role_User_Admin = "Admin";
        public const string Role_User_Employee = "Employee";
        public const string Role_User_Company = "Company user";
        public const string Role_User_Individual = "Individual User";

        //Session
        public const string ssShoppingCartSession = "ShoppingCart";
        //Order status
        public const string StatusPending = "Pending";
        public const string StatusApproved = "Approved";
        public const string StatusInProgress = "Processing";
        public const string StatusShipped = "Shipped";
        public const string StatusCancelled = "Cancelled";
        public const string StatusRejected = "Refunded";

        // Payment status
        public const string PaymentStatusPending = "Pending";
        public const string PaymentStatusApproved = "Approved";
        public const string PaymentStatusDelayPayment = "PaymentStatusDelayPayment";
        public const string PaymentStatusRejected = "Rejected";



        //price based on Quantity
        public static double GetPriceBasedOnQuantity(double quantity, double price, double price50)
        {
            if (quantity < 50)
                return price;
            //else if (quantity < 100)
            //    return price;
            else
                return price50;
        }
        //to remove Tags <p>,<h>etc from html and we pass bold,italic letter 
        public static string ConvertToRawHtml(string source)
        {
            char[] array = new char[source.Length];
            int arrayIndex = 0;
            bool inside = false;
            for (int i = 0; i < source.Length; i++)
            {
                char let = source[i];  //<
                if (let == '<')
                {
                    inside = true;
                    continue;
                }
                if (let == '>')  //>
                {
                    inside = false;
                    continue;
                }
                if (!inside)
                {
                    array[arrayIndex] = let;
                    arrayIndex++;
                }
            }
            return new string(array, 0, arrayIndex);
        }
    }
}
