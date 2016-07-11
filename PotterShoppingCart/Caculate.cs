using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotterShoppingCart
{
    public class Caculate
    {
        public List<Book> bookSet { get; set; }

        public int CaculateShipping()
        {
            return 100;
        }

        public int CaculatePrice(ShoppingCart shoppingCart)
        {
            int totalPrice = 0;

            double buy1book = 1.0;
            double buy2book = 0.95;
            double buy3book = 0.9;
            double buy4book = 0.8;
            double buy5book = 0.75;

            //var bookSet = shoppingCart.books
            //              .GroupBy(x => x.Name)
            //              .Select(g => new { Name = g.Key, Count = g.Count() });

            if (shoppingCart.books.Exists(x => x.Name == "Book1") && shoppingCart.books.Exists(x => x.Name == "Book2"))
            {
                totalPrice = (int)(2 * 100 * buy2book);
            }
            else if (shoppingCart.books.Exists(x => x.Name == "Book1"))
            {
                totalPrice = (int)(1 * 100 * buy1book);
            }

            return totalPrice;
        }
    }


}
