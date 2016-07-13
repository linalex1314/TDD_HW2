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
            var harryPotterBooks = GetBooks();
            var harryPotterDiscount = GetDiscount();   //設定折扣

            List<BookSet> bookSet = SetBookSeries("HarryPotter", harryPotterBooks, harryPotterDiscount);

            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book1"));

            //act
            var actual = target.CaculatePrice(shoppingCart, bookSet);
            var expected = 100;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Buy_book1_book2_price_should_be_100multipliedBy2multipliedByPercent95_result_is_190()
        {
            //arrange  
            var target = new Caculate();
            var harryPotterBooks = GetBooks();
            var harryPotterDiscount = GetDiscount();   //設定折扣

            List<BookSet> bookSet = SetBookSeries("HarryPotter", harryPotterBooks, harryPotterDiscount);

            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book1"));
            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book2"));

            //act
            var actual = target.CaculatePrice(shoppingCart, bookSet);
            var expected = 190;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Buy_book1_book2_book3_price_should_be_100multipliedBy3multipliedByPercent90_result_is_270()
        {
            //arrange  
            var target = new Caculate();
            var harryPotterBooks = GetBooks();
            var harryPotterDiscount = GetDiscount();   //設定折扣

            List<BookSet> bookSet = SetBookSeries("HarryPotter", harryPotterBooks, harryPotterDiscount);

            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book1"));
            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book2"));
            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book3"));

            //act
            var actual = target.CaculatePrice(shoppingCart, bookSet);
            var expected = 270;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Buy_book1_book2_book3_book4_price_should_be_100multipliedBy4multipliedByPercent80_result_is_320()
        {
            //arrange  
            var target = new Caculate();
            var harryPotterBooks = GetBooks();
            var harryPotterDiscount = GetDiscount();   //設定折扣

            List<BookSet> bookSet = SetBookSeries("HarryPotter", harryPotterBooks, harryPotterDiscount);

            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book1"));
            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book2"));
            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book3"));
            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book4"));

            //act
            var actual = target.CaculatePrice(shoppingCart, bookSet);
            var expected = 320;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Buy_book1_book2_book3_book4_book5_price_should_be_100multipliedBy5multipliedByPercent75_result_is_375()
        {
            //arrange
            var target = new Caculate();
            var harryPotterBooks = GetBooks();
            var harryPotterDiscount = GetDiscount();   //設定折扣

            List<BookSet> bookSet = SetBookSeries("HarryPotter", harryPotterBooks, harryPotterDiscount);

            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book1"));
            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book2"));
            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book3"));
            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book4"));
            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book5"));

            //act
            var actual = target.CaculatePrice(shoppingCart, bookSet);


            var expected = 375;

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Buy_book1_book2_book3Twice_price_should_be_100multipliedBy3multipliedByPercent90_Plus100_result_is_370()
        {
            //arrange
            var target = new Caculate();
            var harryPotterBooks = GetBooks();
            var harryPotterDiscount = GetDiscount();   //設定折扣

            List<BookSet> bookSet = SetBookSeries("HarryPotter", harryPotterBooks, harryPotterDiscount);

            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book1"));
            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book2"));
            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book3"));
            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book3"));


            //act
            var actual = target.CaculatePrice(shoppingCart, bookSet);
            var expected = 370;

            //assert
            Assert.AreEqual(expected, actual);
        }

        public void Buy_book1_book2Twice_book3Twice_price_should_be_100multipliedBy3multipliedByPercent90_Plus100multipliedByPercent95_result_is_460()
        {
            //arrange
            var target = new Caculate();
            var harryPotterBooks = GetBooks();
            var harryPotterDiscount = GetDiscount();   //設定折扣

            List<BookSet> bookSet = SetBookSeries("HarryPotter", harryPotterBooks, harryPotterDiscount);

            var shoppingCart = new ShoppingCart();

            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book1"));
            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book2"));
            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book2"));
            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book3"));
            shoppingCart.Add(harryPotterBooks.Find(x => x.Name == "Book3"));


            //act
            var actual = target.CaculatePrice(shoppingCart, bookSet);
            var expected = 460;

            //assert
            Assert.AreEqual(expected, actual);
        }


        private List<BookSet> SetBookSeries(string seriesName, List<Book> bookSeries, List<DiscountSetting> bookDiscount)
        {
            return new List<BookSet>
            {
                new BookSet
                {
                    SeriesName=seriesName,
                    books=bookSeries,
                    bookDiscount=bookDiscount
                }
            };
        }

        private List<Book> GetBooks()
        {
            var books = new List<Book> {
                new Book {SeriesName="HarryPotter", Name="Book1",Price=100},
                new Book {SeriesName="HarryPotter", Name="Book2",Price=100},
                new Book {SeriesName="HarryPotter", Name="Book3",Price=100},
                new Book {SeriesName="HarryPotter", Name="Book4",Price=100},
                new Book {SeriesName="HarryPotter", Name="Book5",Price=100}
                };

            return books;
        }

        private List<DiscountSetting> GetDiscount()
        {
            List<DiscountSetting> discount = new List<DiscountSetting> {
                new DiscountSetting {bookCount=1,discount=1.0 },
                new DiscountSetting {bookCount=2,discount=0.95 },
                new DiscountSetting {bookCount=3,discount=0.9 },
                new DiscountSetting {bookCount=4,discount=0.8 },
                new DiscountSetting {bookCount=5,discount=0.75 }
            };

            return discount;
        }
    }
}