using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterShoppingCart
{
    public class Caculate
    {
        public int CaculateShipping()
        {
            return 100;
        }

        public int CaculatePrice(ShoppingCart shoppingCart)
        {
            int totalPrice = 0;

            if (shoppingCart.books.Count == 1)
            {
                totalPrice = 100;
            }

            return totalPrice;
        }
    }


}
