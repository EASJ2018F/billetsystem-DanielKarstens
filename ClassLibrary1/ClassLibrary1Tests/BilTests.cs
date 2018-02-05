using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class BilTests
    {
        [TestMethod()]
        public void Pristest()
        {
            var Bil = new Bil();
            int Pris = Bil.Pris();
            Assert.AreEqual(240,Pris);
        }
        [TestMethod()]
        public void KøretøjTest()
        {
            var Bil = new Bil();
            string køretøj = Bil.Køretøj();
            Assert.AreEqual("Bil" , køretøj);
        }
        [TestMethod()]
        public void MCPristest()
        {
            var MC = new MC();
            int Pris = MC.Pris();
            Assert.AreEqual(125, Pris);
        }
        [TestMethod()]
        public void MCKøretøjTest()
        {
            var MC = new MC();
            string køretøj = MC.Køretøj();
            Assert.AreEqual("MC", køretøj);
        }
    }
}