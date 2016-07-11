using System;
using System.Collections.Generic;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        public List<Book> books { get; }

        public ShoppingCart()
        {
            books = new List<Book>();
        }

        public void Add(Book book)
        {
            books.Add(book);
        }
    }
}