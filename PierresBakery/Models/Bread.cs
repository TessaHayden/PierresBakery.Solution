using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Price = 5;
    public int static PriceCalc(int breadQuantity)
    {
      int subtractedPrice = breadQuantity / 3;
      return (breadQuantity - subtractedPrice) * Price;
    }
  }
  public class Pastry
  {
    public int Price = 2;
  }
}