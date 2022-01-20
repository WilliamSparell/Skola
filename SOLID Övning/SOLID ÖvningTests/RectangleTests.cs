using Microsoft.VisualStudio.TestTools.UnitTesting;
using SOLID_Övning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Övning.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        public void AreaTest()
        {
            Rectangle r = new Rectangle();
            r.Width = 10;
            r.Height = 10;

            var result = r.Area();

            Assert.IsNotNull(result);
        }
    }
}