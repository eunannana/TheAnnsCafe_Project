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
    public class hotamericanoTests
    {
        [Test()]
        public void c2_priceTest()
        {
            hotamericano ha = new hotamericano();
            {
                double price_result = ha.c2_price(16000);
                Assert.AreEqual(16000, price_result);
            }
        }
    }
}