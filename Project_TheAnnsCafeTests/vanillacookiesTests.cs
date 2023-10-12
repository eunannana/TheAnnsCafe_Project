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
    public class vanillacookiesTests
    {
        [Test()]
        public void s2_priceTest()
        {
            vanillacookies vc = new vanillacookies();
            {
                double price_result = vc.s2_price(5000);
                Assert.AreEqual(5000, price_result);
            }
        }
    }
}