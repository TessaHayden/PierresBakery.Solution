using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void CheckPastryPrice_ReturnTotal_Int()
    {
      Pastry newPastry = new Pastry(2);
      // Arrange
      int testTotal = 4;
      // Act
      int result = newPastry.PriceCalcPastry();
      // Assert
      Assert.AreEqual(testTotal, result);
    }

    [TestMethod]
    public void PriceCalcPastry_ReturnPastryDiscountTotal_Int()
    {
      Pastry newDiscountPastry = new Pastry(4);
      int testTotal = 6;
      int result = newDiscountPastry.PriceCalcPastry();
      Assert.AreEqual(testTotal, result);
    }
  }
}