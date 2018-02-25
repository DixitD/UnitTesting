using System;
using System.Collections.Generic;
using InventorySystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class InventoryTest
    {

        List<Product> p;
        ProductRepository pr;

        //To be intialize a list of product
        [TestInitialize]
        public void InitializeUnitTest()
        {
            p = new List<Product>();
            p.Add(new Product("lettuce", 10.5, 50, "Leafy green"));
            p.Add(new Product("cabbage", 20, 100, "Cruciferous"));
            p.Add(new Product("pumpkin", 30, 30, "Marrow"));
            p.Add(new Product("cauliflower", 10, 25, "Cruciferous"));
            p.Add(new Product("zucchini", 20.5, 50, "Marrow"));
            p.Add(new Product("yam", 30, 50, "Root"));
            p.Add(new Product("spinach", 10, 100, "Leafy green"));
            p.Add(new Product("broccoli", 20.2, 75, "Cruciferous"));
            p.Add(new Product("Garlic", 30, 20, "Leafy green"));
            p.Add(new Product("silverbeet", 10, 50, "Marrow"));
            pr = new ProductRepository(p);
        }
        //Method 1
        //1.assert total no. of product to be 10.
        [TestMethod]
        public void TotalProductTest()
        {
            Assert.AreEqual(10, pr.TotalnoProduct());
        }
        //2.Add one product and then assert total number of products to be 11.
        [TestMethod]
        public void AddProductTest()
        {
            p.Add(new Product("Tomato", 14, 40, "Root"));
            Assert.AreEqual(11, pr.TotalnoProduct());
        }
        //3.Delete two products by it's name and assert total number of product to be 8
        [TestMethod]
        public void DeleteProductsTest()
        {
            pr.Delete("broccoli");
            pr.Delete("zucchini");
            Assert.AreEqual(8, pr.TotalnoProduct());
        }


        //Method 2
        //1.Add new product in list and assert total number of products in list
        [TestMethod]
        public void AddProductLengthTest()
        {
            Assert.AreEqual(11, pr.Add(new Product("Tomato", 14, 40, "Root")).Count);
        }
        //2.Add new product in list and assert new prduct is on last index of list
        [TestMethod]
        public void NewProductIndexTest()
        {
            var p = new Product("Tomato", 14, 40, "Root");
            var list = pr.Add(p);
            Assert.AreEqual(p, list[list.Count - 1]);
        }


        //Method 3
        //1.Get Product by name and assert total number of producct of specific type
        [TestMethod]
        public void FindProductTest()
        {
            Assert.AreEqual(3, pr.Find("Cruciferous").Count);
        }

        //2.Get product list which has type marrow 
        [TestMethod]
        public void FindProductCountTest()
        {
            var M = pr.Find("Marrow");
            var FM = M.FindAll(x => x.P_type.Equals("Marrow"));
            Assert.AreEqual(M.Count, FM.Count);
        }


        //Method 4
        //1.Delete product which has name pumpkin and assert total number of product in list
        [TestMethod]
        public void DeleteProductTest()
        {
            Assert.AreEqual(9, pr.Delete("pumpkin").Count);
        }
        //2.Delete product which has name cabbage and assert returned list must not contain cabbage
        [TestMethod]
        public void DeleteBProductfindTest()
        {
            var C = pr.Delete("cabbage");
            var FC = C.FindAll(x => x.P_name.Equals("cabbage"));
            Assert.AreEqual(0, FC.Count);
        }

        //Method 5
        //1.Buy grocery and assert total price of it
        [TestMethod]
        public void BuyProductTotalPriceTest()
        {
            var Price1 = pr.Buy("cauliflower", 3);
                var Price2 = pr.Buy("cabbage", 3);
                var Price3 = pr.Buy("zucchini", 2);
                Assert.AreEqual(131 , Price1 + Price2 + Price3);
        }

    }
}

