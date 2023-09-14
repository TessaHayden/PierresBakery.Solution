using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PierresBakery.Models;

namespace PierresBakery.Tests
{
  [TestClass]
  public class Bread
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void CheckBreadPrice_ReturnTotal_Int()
    {
      Bread newBread = new Bread();
      int breadQuantity = 5;
      int result = newBread.PriceCalcBread(breadQuantity);
      Assert.AreEqual(20, result);
    }
  }
}