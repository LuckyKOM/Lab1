using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store;
using System.Collections.Generic;

namespace ClientTest
{
    [TestClass]
    public class WareHouseTest
    {
        [TestMethod]
        public void TestRetreiveAllProducts()   //testing wareHouse.RetreiveAllProducts()
        {
            //Arrange static data
            var masterList = new List<Product>()
          {
           new Books()
            {
                ProductId = 10,
                Title = "War and Piece",
                Description = "Epic novel",
                Author = "L. Tosltoy",
                YearOfPublish = 2010,
                Price = 189
            },

         new TVsets()
            {
                ProductId = 20,
                Title = "Sony KD 55",
                Description = "LCD TV set",
                Price = 4000
            },
            new TVsets()
            {
                ProductId = 30,
                Title = "Samsung UE 43K",
                Description = "LCD TV set",
                Price = 5000
            }
          };

            WareHouse wareHouse = new WareHouse();
            List<Product> actualList = wareHouse.ProductList;
            Assert.AreEqual(actualList.Count, masterList.Count);
        }
          
  
        [TestMethod]
        public void TestRetreiveProduct()
        {

            var masterProduct = new Product()
            {
                ProductId = 20,
                Title = "Sony KD 55",
                Description = "LCD TV set",
                Price = 4000
            };
            var wareHouse = new WareHouse();
        Product  actualProduct = wareHouse.RetreiveProduct(20);
            bool equal = ((actualProduct.ProductId == masterProduct.ProductId)
                   && (actualProduct.Title == masterProduct.Title)
                  && (actualProduct.Description == masterProduct.Description)
                  && (actualProduct.Price == masterProduct.Price));
                Assert.IsTrue(equal); 
            

        }

        [TestMethod]
        public void TestDeleteProduct()
        {
            var wareHouse = new WareHouse();
            Product product = wareHouse.RetreiveProduct(20);
            int countBefore = wareHouse.ProductList.Count ;
           wareHouse.DeleteProduct(product);
            int countAfter = wareHouse.ProductList.Count;
            Assert.IsTrue((countBefore - countAfter) == 1 );
        }

    }
}
