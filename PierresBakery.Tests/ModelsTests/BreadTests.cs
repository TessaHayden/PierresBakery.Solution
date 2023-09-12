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
    public void GetBreadQuantity_ReturnBreadQuantity_Int()
    {
      int setQty = 3;
      Bread breadOrder = new Bread(setQty);
      int result = breadOrder.Quantity;
      Assert.AreEqual(setQty, result);
    }
  }
}