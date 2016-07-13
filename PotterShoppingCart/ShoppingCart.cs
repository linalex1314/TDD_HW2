using PotterShoppingCart;
using System.Collections.Generic;

namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        public List<Product> products { get; }

        public ShoppingCart()
        {
            products = new List<Product>();
        }

        public void Add(Book book, int quantity)
        {
            products.Add(new Product { book = book, Quantity = quantity });
        }
    }
}