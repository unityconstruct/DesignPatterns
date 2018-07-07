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
            var thingy = up.AThingy;
            thingy.Name = "NEWNAME";
            thingy.Value = "NEWVALUE";
            Console.WriteLine($"Thingy Name=\"{thingy.Name}\", Thingy Value: \"{thingy.Value}\"");
            Assert.AreSame(up.AThingy, up.AThingy);

            var thingy2 = up.AThingy;
            Assert.AreSame(thingy, thingy2);
        }
    }
}
