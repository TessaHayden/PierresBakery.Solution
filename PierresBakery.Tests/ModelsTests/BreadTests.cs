using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void CheckBreadPrice_ReturnTotal_Int()
    {
      Bread newBread = new Bread(2);
      // Arrange
      int testTotal = 10;
      // Act
      int result = newBread.PriceCalcBread();
      // Assert
      Assert.AreEqual(testTotal, result);
    }

    [TestMethod]
    public void PriceCalcBread_ReturnBreadDiscountTotal_Int()
    {
      Bread newDiscountBread = new Bread(3);
      int testTotal = 10;
      int result = newDiscountBread.PriceCalcBread();
      Assert.AreEqual(testTotal, result);
    }
  }
}