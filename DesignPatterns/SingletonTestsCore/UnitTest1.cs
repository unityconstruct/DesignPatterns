using Microsoft.VisualStudio.TestTools.UnitTesting;
using Singleton;
using System;

namespace SingletonTestsCore
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreSame(Dashboard.Instance, Dashboard.Instance);
            Console.WriteLine($"Dashboard.Instance.GetName(): {Dashboard.Instance.GetName()}");
            Dashboard.Instance.SetDashName("NewDashName");
            Console.WriteLine($"Instance.GetDashName: {Dashboard.Instance.GetDashName()}");
            Console.WriteLine($"Instance.GetName: {Dashboard.Instance.GetName()}");
        }
    }
}
