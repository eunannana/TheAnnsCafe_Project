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
    public class hotcappucinoTests
    {
        [Test()]
        public void c4_priceTest()
        {
            hotcappucino hc = new hotcappucino();
            {
                double price_result = hc.c4_price(20000);
                Assert.AreEqual(20000, price_result);
            }
        }
    }
}