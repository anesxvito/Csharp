| Enhance the .NET Framework and .NET Core with over 1000 extension methods.


():


using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Z.Core.Test
{
    [TestClass]
    public class System_DateTime_IsDateEqual
    {
        [TestMethod]
        public void IsDateEqual()
        {
            // Type
            var @thisMorning = new DateTime(2014, 04, 12, 8, 0, 0);
            var @thisAfternoon = new DateTime(2014, 04, 12, 17, 0, 0);

            // Exemples
            bool result = @thisMorning.IsDateEqual(@thisAfternoon); // return true;

            // Unit Test
            Assert.IsTrue(result);
        }
    }
}