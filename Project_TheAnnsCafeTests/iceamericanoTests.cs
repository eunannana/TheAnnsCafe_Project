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
    public class iceamericanoTests
    {
        [Test()]
        public void c1_priceTest()
        {
            iceamericano ia = new iceamericano();
            {
                double price_result = ia.c1_price(18000);
                Assert.AreEqual(18000, price_result);
            }
        }
    }
}