using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using InsuranceService;

namespace InsuranceService.Test
{
    [TestFixture]
    public class Class1
    {
       
        [Test]
        public static void test1()
        {
            //Arrange
            InsuranceService.Program p1 = new Program();

            //Act
            double actualResult = p1.CalcPremium(18, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(60));

        }
        [Test]
        public static void test2()
        {
            //Arrange
            InsuranceService.Program p2 = new Program();

            //Act
            double actualResult = p2.CalcPremium(50, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(25));

        }
        [Test]
        public static void test3()
        {
            //Arrange
            InsuranceService.Program p3 = new Program();

            //Act
            double actualResult = p3.CalcPremium(17, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test4()
        {
            //Arrange
            InsuranceService.Program p4 = new Program();

            //Act
            double actualResult = p4.CalcPremium(55, "other");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test5()
        {
            //Arrange
            InsuranceService.Program p5 = new Program();

            //Act
            double actualResult = p5.CalcPremium(18, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(50));

        }
        [Test]
        public static void test6()
        {
            //Arrange
            InsuranceService.Program p6 = new Program();

            //Act
            double actualResult = p6.CalcPremium(55, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(25));

        }
        [Test]
        public static void test7()
        {
            //Arrange
            InsuranceService.Program p6 = new Program();

            //Act
            double actualResult = p6.CalcPremium(17, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }

    }
}
