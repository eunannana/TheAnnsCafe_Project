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
    public class chocolatecookiesTests
    {
        [Test()]
        public void s1_priceTest()
        {
            chocolatecookies cc = new chocolatecookies();
            {
                double price_result = cc.s1_price(5000);
                Assert.AreEqual(5000, price_result);
            }
        }
    }
}