using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfService_CI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService_CI.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void BeregnSumTest7()
        {
            Service1 service = new Service1();

            int udregning = service.BeregnSum(2, 5);

            Assert.AreEqual(udregning, 7);
        }

        [TestMethod()]
        public void BeregnSumTest8()
        {
            Service1 service = new Service1();

            int udregning = service.BeregnSum(3, 5);

            Assert.AreEqual(udregning, 8);
        }
    }
}