using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Tests
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void AddTest()
        {
            Assert.AreEqual(4, ConsoleApplication1.Program.Add(2, 2));
        }

    }
}
