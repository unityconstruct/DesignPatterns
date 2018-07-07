using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DesignPatterns2016.Tests
{
    [TestClass]
    public class UsingPropertiesTests
    {
        [TestMethod]
        public void TestingThingyGet()
        {
            //Assert.AreSame(Using)
            UsingProperties up = new UsingProperties();
            up.Name = "NEWNAME";
            var thingy = up.AThingy;
            Console.WriteLine($"Thingy Name=\"{thingy.Name}\", Thingy Value: \"{thingy.Value}\"");
            Assert.AreSame(up.AThingy, up.AThingy);
        }
    }
}
