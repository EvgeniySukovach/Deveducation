using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit;
using NUnit.Framework;

namespace Citizen
{
    
    class Class1


    {
        [Test]
        public void myTest() {
            var test = 2 + 2;
            Assert.AreEqual(4, test);

        }
    }
}
