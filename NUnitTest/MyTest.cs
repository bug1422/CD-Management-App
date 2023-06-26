using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTest
{
    [TestFixture]
    class MyTest
    {
        [TestCase]
        public void addTest()
        {
            Assert.AreEqual(31, 31);
        }
    }
}
