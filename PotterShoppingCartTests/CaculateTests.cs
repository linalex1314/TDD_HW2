using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class CaculateTests
    {
        [TestMethod()]
        public void Buy_book1_price_should_be_100()
        {
            //arrange
            var target = new Caculate();
            var books = GetBooks();

            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(books.Find(x => x.Name == "Book1"));

            //act
            var actual = target.CaculatePrice(shoppingCart);
            var expected = 100;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Buy_book1_book2_price_should_be_100multipliedBy2multipliedByPercent95_result_is_190()
        {
            //arrange
            var target = new Caculate();
            var books = GetBooks();

            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(books.Find(x => x.Name == "Book1"));
            shoppingCart.Add(books.Find(x => x.Name == "Book2"));

            //act
            var actual = target.CaculatePrice(shoppingCart);
            var expected = 190;

            //assert
            Assert.AreEqual(expected, actual);
        }

        private List<Book> GetBooks()
        {
            var books = new List<Book> {
                new Book { Name="Book1",Price=100},
                new Book { Name="Book2",Price=100},
                new Book { Name="Book3",Price=100},
                new Book { Name="Book4",Price=100},
                new Book { Name="Book5",Price=100}
                };

            return books;
        }
    }
}