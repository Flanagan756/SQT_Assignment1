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
            double actualResult = p1.CalcPremium(17, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test2()
        {
            //Arrange
            InsuranceService.Program p2 = new Program();

            //Act
            double actualResult = p2.CalcPremium(18, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(50));

        }
        [Test]
        public static void test3()
        {
            //Arrange
            InsuranceService.Program p3 = new Program();

            //Act
            double actualResult = p3.CalcPremium(29, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(50));

        }
        [Test]
        public static void test4()
        {
            //Arrange
            InsuranceService.Program p4 = new Program();

            //Act
            double actualResult = p4.CalcPremium(30, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(35));

        }
        [Test]
        public static void test5()
        {
            //Arrange
            InsuranceService.Program p5 = new Program();

            //Act
            double actualResult = p5.CalcPremium(31, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(35));

        }
        [Test]
        public static void test6()
        {
            //Arrange
            InsuranceService.Program p6 = new Program();

            //Act
            double actualResult = p6.CalcPremium(49, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(17.5));

        }
        [Test]
        public static void test7()
        {
            //Arrange
            InsuranceService.Program p7 = new Program();

            //Act
            double actualResult = p7.CalcPremium(50, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test8()
        {
            //Arrange
            InsuranceService.Program p8 = new Program();

            //Act
            double actualResult = p8.CalcPremium(18, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(60));

        }
        [Test]
        public static void test9()
        {
            //Arrange
            InsuranceService.Program p9 = new Program();

            //Act
            double actualResult = p9.CalcPremium(34, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(60));

        }
        [Test]
        public static void test10()
        {
            //Arrange
            InsuranceService.Program p10 = new Program();

            //Act
            double actualResult = p10.CalcPremium(35, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(60));

        }
        [Test]
        public static void test11()
        {
            //Arrange
            InsuranceService.Program p11 = new Program();

            //Act
            double actualResult = p11.CalcPremium(36, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(50));

        }
        [Test]
        public static void test12()
        {
            //Arrange
            InsuranceService.Program p12 = new Program();

            //Act
            double actualResult = p12.CalcPremium(49, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(50));

        }
        [Test]
        public static void test13()
        {
            //Arrange
            InsuranceService.Program p13 = new Program();

            //Act
            double actualResult = p13.CalcPremium(50, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(25));

        }
        [Test]
        public static void test14()
        {
            //Arrange
            InsuranceService.Program p14 = new Program();

            //Act
            double actualResult = p14.CalcPremium(0, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test15()
        {
            //Arrange
            InsuranceService.Program p15 = new Program();

            //Act
            double actualResult = p15.CalcPremium(-1, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test16()
        {
            //Arrange
            InsuranceService.Program p16 = new Program();

            //Act
            double actualResult = p16.CalcPremium(18, "city");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test17()
        {
            //Arrange
            InsuranceService.Program p17 = new Program();

            //Act
            double actualResult = p17.CalcPremium(0, "city");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test18()
        {
            //Arrange
            InsuranceService.Program p18 = new Program();

            //Act
            double actualResult = p18.CalcPremium(17, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }


    }
}
