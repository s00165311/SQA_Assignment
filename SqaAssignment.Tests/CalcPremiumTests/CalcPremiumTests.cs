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
        //FEMALE 
        //First branch test: Check if female and is younger than 30 years old.
        [Test]
        public void FemLessthanOrEqual30()
        {
            var sut = new CalculatePremium();
            var result = sut.CalcPremium(20, "female");
            Assert.That(result, Is.EqualTo(5.0F));
        }

        //Second branch test: Check if female and age is equal to or greater than 31
        [Test]
        public void FemOver30()
        {
            var sut = new CalculatePremium();
            var result = sut.CalcPremium(32, "female");
            Assert.That(result, Is.EqualTo(2.50F));
        }

        //Third branch test: Check if female and age less than 18
        [Test]
        public void FemLessThan18()
        {
            var sut = new CalculatePremium();
            var result = sut.CalcPremium(17, "female");
            Assert.That(result, Is.EqualTo(0.0F));
        }

        //MALE 
        //First branch test: Check if Male and is younger than 36 years old.
        [Test]
        public void ManLessthanOrEqual30()
        {
            var sut = new CalculatePremium();
            var result = sut.CalcPremium(32, "male");
            Assert.That(result, Is.EqualTo(6.0F));
        }

        //Second branch test: Check if Male and age is equal to or greater than 36
        [Test]
        public void ManOver30()
        {
            var sut = new CalculatePremium();
            var result = sut.CalcPremium(40, "male");
            Assert.That(result, Is.EqualTo(5.0F));
        }

        //Third branch test: Check if male and age less than 18
        [Test]
        public void ManLessThan18()
        {
            var sut = new CalculatePremium();
            var result = sut.CalcPremium(17, "male");
            Assert.That(result, Is.EqualTo(0.0F));
        }


        //Neither Male or Female
        [Test]
        public void GenderIssues()
        {
            var sut = new CalculatePremium();
            var result = sut.CalcPremium(17, "trans");
            Assert.That(result, Is.EqualTo(0.0F));
        }

        [Test]
        public void Over51M()
        {
            var sut = new CalculatePremium();
            var result = sut.CalcPremium(51, "male");
            Assert.That(result, Is.EqualTo(0.75F));
        }

        [Test]
        public void Over51F()
        {
            var sut = new CalculatePremium();
            var result = sut.CalcPremium(51, "female");
            Assert.That(result, Is.EqualTo(0.375F));
        }

        [Test]
        public void Over51T()
        {
            var sut = new CalculatePremium();
            var result = sut.CalcPremium(51, "trans");
            Assert.That(result, Is.EqualTo(0.0F));
        }
    }
}
