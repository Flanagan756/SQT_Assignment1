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
            double actualResult = p1.CalcPremium(-1, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test2()
        {
            //Arrange
            InsuranceService.Program p2 = new Program();

            //Act
            double actualResult = p2.CalcPremium(0, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test3()
        {
            //Arrange
            InsuranceService.Program p3 = new Program();

            //Act
            double actualResult = p3.CalcPremium(17, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test4()
        {
            //Arrange
            InsuranceService.Program p4 = new Program();

            //Act
            double actualResult = p4.CalcPremium(18, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(50));

        }
        [Test]
        public static void test5()
        {
            //Arrange
            InsuranceService.Program p5 = new Program();

            //Act
            double actualResult = p5.CalcPremium(29, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(50));

        }
        [Test]
        public static void test6()
        {
            //Arrange
            InsuranceService.Program p6 = new Program();

            //Act
            double actualResult = p6.CalcPremium(30, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(50));

        }
        [Test]
        public static void test7()
        {
            //Arrange
            InsuranceService.Program p7 = new Program();

            //Act
            double actualResult = p7.CalcPremium(31, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(35));

        }
        [Test]
        public static void test8()
        {
            //Arrange
            InsuranceService.Program p8 = new Program();

            //Act
            double actualResult = p8.CalcPremium(35, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(35));

        }
        [Test]
        public static void test9()
        {
            //Arrange
            InsuranceService.Program p9 = new Program();

            //Act
            double actualResult = p9.CalcPremium(36, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(35));

        }
        [Test]
        public static void test10()
        {
            //Arrange
            InsuranceService.Program p10 = new Program();

            //Act
            double actualResult = p10.CalcPremium(49, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(35));

        }
        [Test]
        public static void test11()
        {
            //Arrange
            InsuranceService.Program p11 = new Program();

            //Act
            double actualResult = p11.CalcPremium(50, "urban");

            //Assert
            Assert.That(actualResult, Is.EqualTo(17.5));

        }
        [Test]
        public static void test12()
        {
            //Arrange
            InsuranceService.Program p12 = new Program();

            //Act
            double actualResult = p12.CalcPremium(-1, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test13()
        {
            //Arrange
            InsuranceService.Program p13 = new Program();

            //Act
            double actualResult = p13.CalcPremium(0, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test14()
        {
            //Arrange
            InsuranceService.Program p14 = new Program();

            //Act
            double actualResult = p14.CalcPremium(17, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test15()
        {
            //Arrange
            InsuranceService.Program p15 = new Program();

            //Act
            double actualResult = p15.CalcPremium(18, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(60));

        }
        [Test]
        public static void test16()
        {
            //Arrange
            InsuranceService.Program p16 = new Program();

            //Act
            double actualResult = p16.CalcPremium(29, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(60));

        }
        [Test]
        public static void test17()
        {
            //Arrange
            InsuranceService.Program p17 = new Program();

            //Act
            double actualResult = p17.CalcPremium(30, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(60));

        }
        [Test]
        public static void test18()
        {
            //Arrange
            InsuranceService.Program p18 = new Program();

            //Act
            double actualResult = p18.CalcPremium(31, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(60));

        }
        [Test]
        public static void test19()
        {
            //Arrange
            InsuranceService.Program p18 = new Program();

            //Act
            double actualResult = p18.CalcPremium(35, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(60));

        }
        [Test]
        public static void test20()
        {
            //Arrange
            InsuranceService.Program p18 = new Program();

            //Act
            double actualResult = p18.CalcPremium(36, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(50));

        }
        [Test]
        public static void test21()
        {
            //Arrange
            InsuranceService.Program p18 = new Program();

            //Act
            double actualResult = p18.CalcPremium(49, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(50));

        }
        [Test]
        public static void test22()
        {
            //Arrange
            InsuranceService.Program p18 = new Program();

            //Act
            double actualResult = p18.CalcPremium(50, "rural");

            //Assert
            Assert.That(actualResult, Is.EqualTo(25));

        }
        [Test]
        public static void test23()
        {
            //Arrange
            InsuranceService.Program p18 = new Program();

            //Act
            double actualResult = p18.CalcPremium(-1, "city");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test24()
        {
            //Arrange
            InsuranceService.Program p18 = new Program();

            //Act
            double actualResult = p18.CalcPremium(0, "city");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test25()
        {
            //Arrange
            InsuranceService.Program p18 = new Program();

            //Act
            double actualResult = p18.CalcPremium(17, "city");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test26()
        {
            //Arrange
            InsuranceService.Program p18 = new Program();

            //Act
            double actualResult = p18.CalcPremium(18, "city");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test27()
        {
            //Arrange
            InsuranceService.Program p18 = new Program();

            //Act
            double actualResult = p18.CalcPremium(29, "city");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test28()
        {
            //Arrange
            InsuranceService.Program p18 = new Program();

            //Act
            double actualResult = p18.CalcPremium(30, "city");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test29()
        {
            //Arrange
            InsuranceService.Program p18 = new Program();

            //Act
            double actualResult = p18.CalcPremium(31, "city");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test30()
        {
            //Arrange
            InsuranceService.Program p18 = new Program();

            //Act
            double actualResult = p18.CalcPremium(35, "city");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test31()
        {
            //Arrange
            InsuranceService.Program p18 = new Program();

            //Act
            double actualResult = p18.CalcPremium(36, "city");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test32()
        {
            //Arrange
            InsuranceService.Program p18 = new Program();

            //Act
            double actualResult = p18.CalcPremium(49, "city");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
        [Test]
        public static void test33()
        {
            //Arrange
            InsuranceService.Program p18 = new Program();

            //Act
            double actualResult = p18.CalcPremium(50, "city");

            //Assert
            Assert.That(actualResult, Is.EqualTo(0));

        }
   
    }
}
