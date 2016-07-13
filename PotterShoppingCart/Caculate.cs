using System.Collections.Generic;
using System.Linq;

namespace PotterShoppingCart
{
    public class Caculate
    {
        public int CaculateShipping()
        {
            return 100;
        }

        /// <summary>
        /// 計算金額
        /// </summary>
        /// <param name="shoppingCart">購物車書籍</param>
        /// <param name="bookSet">叢書設定</param>
        /// <returns></returns>
        public int CaculatePrice(ShoppingCart shoppingCart, List<BookSet> bookSet)
        {
            int totalPrice = 0;

            //總共有幾套書
            var userSet = shoppingCart.books
              .GroupBy(x => new { SeriesName = x.SeriesName, Name = x.Name, Price = x.Price })
                .Select(lg =>
                new
                {
                    SeriesName = lg.Key.SeriesName,
                    Name = lg.Key.Name,
                    Price = lg.Key.Price,
                    Total = lg.Count()
                }).ToList();

            int maxSet = shoppingCart.books
                .GroupBy(x => new { SeriesName = x.SeriesName, Name = x.Name, Price = x.Price })
                .Select(lg =>
                new
                {
                    SeriesName = lg.Key.SeriesName,
                    Name = lg.Key.Name,
                    Price = lg.Key.Price,
                    Total = lg.Count()
                }).Max(z => z.Total);

            int i = 1;
            var userBuyBookSet = new List<BookSet>();

            while (i <= maxSet)
            {
                var thisTern = userSet.Where(x => x.Total >= i).ToList();

                List<Book> tmp = new List<Book>();
                foreach (var book in thisTern)
                {
                    tmp.Add(new Book { SeriesName = book.SeriesName, Name = book.Name, Price = book.Price });
                }

                if (tmp != null)
                {
                    userBuyBookSet.Add(
                            new BookSet()
                            {
                                SeriesName = tmp[0].SeriesName,
                                books = tmp
                            });
                }

                i++;
            }

            foreach (var userbookset in userBuyBookSet)
            {
                var discount = bookSet.Find(x => x.SeriesName == userbookset.SeriesName).bookDiscount.Find(y => y.bookCount == userbookset.books.Count).discount;

                foreach (var book in userbookset.books)
                {
                    totalPrice += (int)(book.Price * discount);
                }
            }

            return totalPrice;
        }
    }
}