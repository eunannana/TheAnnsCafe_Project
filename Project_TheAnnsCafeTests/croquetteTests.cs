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
    public class croquetteTests
    {
        [Test()]
        public void s5_priceTest()
        {
            croquette cr = new croquette();
            {
                double price_result = cr.s5_price(12000);
                Assert.AreEqual(12000, price_result);
            }
        }
    }
}