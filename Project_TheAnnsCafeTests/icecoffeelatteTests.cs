using NUnit.Framework;
using Project_TheAnnsCafe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_TheAnnsCafe.Tests
{
    [TestFixture()]
    public class icecoffeelatteTests
    {
        [Test()]
        public void c7_priceTest()
        {
            icecoffeelatte icl = new icecoffeelatte();
            {
                double price_result = icl.c7_price(23000);
                Assert.AreEqual(23000, price_result);
            }
        }
    }
}