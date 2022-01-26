using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TestSolution;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        public DevCode obj = new DevCode();

        [TestMethod]
        public void VerifyEmpName()
        {
            obj.NewEmployee("Dave", "001");
            Assert.AreEqual("Dave", obj.empName);
        }

        [TestMethod]
        public void VerifyEmpId()
        {
            obj.NewEmployee("John", "002");
            Assert.AreEqual("002", obj.empId);
        }
    }
}
