using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public static int Price = 5;
    public static int PriceCalcBread(int breadQuantity)
    {
      int subtractedPrice = breadQuantity / 3;
      return (breadQuantity - subtractedPrice) * Price;
    }
  }
  public class Pastry
  {
    public static int Price = 2;
    public static int PriceCalcPastry(int pastryQuantity)
    {
      int subtractedPrice = pastryQuantity / 4;
      return (pastryQuantity - subtractedPrice) * Price;x
    }
  }
}