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
    public class icemochachinoTests
    {
        [Test()]
        public void c9_priceTest()
        {
            icemochachino im = new icemochachino();
            {
                double price_result = im.c9_price(21000);
                Assert.AreEqual(21000, price_result);
            }
        }
    }
}