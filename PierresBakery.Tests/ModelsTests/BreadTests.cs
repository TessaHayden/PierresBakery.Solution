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
    public void BreadFindQuantity_ReturnsQuantityOfType_Int()
    {
      int setQuantity = 5;
      Bread newBread = new Bread(setQuantity);
      Assert.AreEqual(setQuantity, newBread.Quantity);
    }
  }
}