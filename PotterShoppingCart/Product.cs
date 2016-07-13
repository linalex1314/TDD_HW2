using System.Collections.Generic;

namespace PotterShoppingCart
{
    public class Book
    {
        public string SeriesName { get; set; }  //叢書名稱

        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class BookSet
    {
        public string SeriesName { get; set; }  //叢書名稱

        public List<Book> books { get; set; }

        public List<DiscountSetting> bookDiscount { get; set; }
    }

    public class Product
    {
        public Book book { get; set; }

        public int Quantity { get; set; }
    }
}