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
    public class coffeecookiesTests
    {
        [Test()]
        public void s3_priceTest()
        {
            coffeecookies fc = new coffeecookies();
            {
                double price_result = fc.s3_price(5000);
                Assert.AreEqual(5000, price_result);
            }
        }
    }
}