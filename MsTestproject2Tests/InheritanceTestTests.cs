using Microsoft.VisualStudio.TestTools.UnitTesting;
using MsTestproject2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTestproject2.Tests
{
    [TestClass()]
    public class InheritanceTestTests
    {
        [TestMethod()]
        public void startTest()
        {
            InheritanceTest i=new InheritanceTest();
            string s = i.start();
            Assert.AreEqual("Vehicle started", s);
            
        }
        [TestMethod()]

        public void childMethod()
        {
            Bike b=new Bike();
            string s=b.start();
            Assert.AreEqual("Kick start", s);
        }
    }
}