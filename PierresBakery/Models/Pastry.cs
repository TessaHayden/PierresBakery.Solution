using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Quantity { get; set; }
    public int Price = 0;
    public int Total = 0;
    public Pastry(int quantity)
    {
      Quantity = quantity;
    }
    public int SetPrice()
    {
      if (Quantity == x % 1)
      {
        Price = double 2.5;
      }
      else if (Quantity == x % 0)
      {
        Price = int 5
      }
    }
    public int SetTotal()
    {
      Total = Price * Quantity
    }
  }
}