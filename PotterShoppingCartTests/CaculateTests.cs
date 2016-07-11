using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PotterShoppingCart.Tests
{
    [TestClass()]
    public class CaculateTests
    {
        [TestMethod()]
        public void Buy_1_book_price_should_be_100()
        {
            //arrange
            var target = new Caculate();

            var bookRepository = new List<Book> {
                new Book { Name="Book1",Price=100},
                new Book { Name="Book2",Price=100},
                new Book { Name="Book3",Price=100},
                new Book { Name="Book4",Price=100},
                new Book { Name="Book5",Price=100}
                };

            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(bookRepository.Find(x => x.Name == "Book1"));

            //act
            var actual = target.CaculatePrice(shoppingCart);
            var expected = 100;

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}