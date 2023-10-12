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
    public class hotcaramelmacchiattoTests
    {
        [Test()]
        public void c6_priceTest()
        {
            hotcaramelmacchiatto hcm = new hotcaramelmacchiatto();
            {
                double price_result = hcm.c6_price(20000);
                Assert.AreEqual(20000, price_result);
            }
        }
    }
}