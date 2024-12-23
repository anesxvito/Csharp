| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_Age
    {
        [TestMethod]
        public void Age()
        {
            // Type
            var @this = new DateTime(1981, 01, 01);

            // Exemples
            int result = @this.Age(); // result CurrentYear - 1981

            // Unit Test
            Assert.AreEqual(DateTime.Now.Year - 1981, result);
        }
    }
}