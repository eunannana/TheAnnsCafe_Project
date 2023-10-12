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
    public class icecaramelmacchiattoTests
    {
        [Test()]
        public void c5_priceTest()
        {
            icecaramelmacchiatto icm = new icecaramelmacchiatto();
            {
                double price_result = icm.c5_price(22000);
                Assert.AreEqual(22000, price_result);
            }
        }
    }
}