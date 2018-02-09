using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqaAssignment.Tests.CalcPremiumTests
{
    [TestFixture]
    class CalcPremiumTests
    {
        [Test]
        public void test01()
        {
            var sut = new CalculatePremium();
            var result = sut.CalcPremium(20, "female");
            Assert.That(result, Is.EqualTo(5.0F));
        }
    }
}
