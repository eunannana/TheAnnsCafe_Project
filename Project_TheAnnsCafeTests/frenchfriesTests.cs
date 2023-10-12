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
    public class frenchfriesTests
    {
        [Test()]
        public void s4_priceTest()
        {
            frenchfries ff = new frenchfries();
            {
                double price_result = ff.s4_price(10000);
                Assert.AreEqual(10000, price_result);
            }
        }
    }
}