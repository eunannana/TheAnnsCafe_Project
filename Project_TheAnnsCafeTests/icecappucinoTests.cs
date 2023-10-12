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
    public class icecappucinoTests
    {
        [Test()]
        public void c3_priceTest()
        {
            icecappucino ic = new icecappucino();
            {
                double price_result = ic.c3_price(22000);
                Assert.AreEqual(22000, price_result);
            }
        }
    }
}