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

            List<DisCount> discount = new List<DisCount> {
                new DisCount {bookCount=1,disCountSet=1.0 },
                new DisCount {bookCount=2,disCountSet=0.95 },
                new DisCount {bookCount=3,disCountSet=0.9 },
                new DisCount {bookCount=4,disCountSet=0.8 },
                new DisCount {bookCount=5,disCountSet=0.75 }
            };

            foreach (Book book in shoppingCart.books)
            {
                totalPrice += (int)(book.Price * discount.Find(x => x.bookCount == shoppingCart.books.Count).disCountSet);
            }

            return totalPrice;
        }
    }


}
