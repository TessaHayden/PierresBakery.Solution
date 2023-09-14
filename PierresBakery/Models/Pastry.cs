using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Price { get; set; }
    public int Quantity { get; set; }

    public Pastry(int quantity)
    {
      Quantity = quantity;
      Price = 2;
    }
    public int PriceCalcPastry()
    {
      int subtractedPrice = Quantity / 3;
      return (Quantity - subtractedPrice) * Price;
    }
  }
}

