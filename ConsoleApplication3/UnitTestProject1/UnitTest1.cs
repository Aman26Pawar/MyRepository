using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication3;
using Moq;


namespace UnitTestProject1
{
    [TestClass]
    public class CalculatorFunctionsTest1
    {
       // [TestMethod]
        //public void Addition_ValidResult()
        //{
        //    //Arrange
        //    CalculatorFunctions cfun = new CalculatorFunctions();
        //    //Act
        //    int result = cfun.Addition(1,2);

        //  //Assert
        //    Assert.AreEqual(3, result, "Result is not correct");
        //}

        //[TestMethod]
        //public void Addition_ValidInput()
        //{
        //    CalculatorFunctions cfun = new CalculatorFunctions();
        //    int result = cfun.Addition(1,2);

        //    Assert.AreEqual(3, result, "Input is not correct");
        //}




        [TestMethod]
        public void Addition_ValidInput_ResultSuccess()
        {
            CalculatorFunctions cfun = new CalculatorFunctions();
            Mock<AccessingClass> access = new Mock<AccessingClass>();
            access.Setup(x => x.AccessFunction()).Returns("wqef2w ");
            int result = cfun.Addition(1, 2,access.Object);

            Assert.AreEqual(53, result,result.ToString());
        }



    }
}
