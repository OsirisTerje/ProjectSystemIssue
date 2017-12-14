using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace LibA
{
    public class TestWhatever
    {
        [Test]
        public void TestMathAdd()
        {
            var sut = new LibB.Math();
            var res = sut.Add(2, 3);
            Assert.That(res,Is.EqualTo(5));
        }
    }
}
