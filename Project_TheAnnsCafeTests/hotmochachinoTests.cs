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
    public class hotmochachinoTests
    {
        [Test()]
        public void c10_priceTest()
        {
            hotmochachino hm = new hotmochachino();
            {
                double price_result = hm.c10_price(19000);
                Assert.AreEqual(19000, price_result);
            }
        }
    }
}