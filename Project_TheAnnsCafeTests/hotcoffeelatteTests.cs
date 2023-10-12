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
    public class hotcoffeelatteTests
    {
        [Test()]
        public void c8_priceTest()
        {
            hotcoffeelatte hcl = new hotcoffeelatte();
            {
                double price_result = hcl.c8_price(21000);
                Assert.AreEqual(21000, price_result);
            }
        }
    }
}