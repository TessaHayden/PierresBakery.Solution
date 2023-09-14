using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Price { get; set; }
    public int Quantity { get; set; }

    public Bread(int quantity)
    {
      Quantity = quantity;
      Price = 5;
    }
    public int PriceCalcBread()
    {
      int subtractedPrice = Quantity / 3;
      return (Quantity - subtractedPrice) * Price;
    }
  }
}

