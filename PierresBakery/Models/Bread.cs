using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Price;
    public int Quantity;
    public int Total;
    public Bread(int price, int quantity, int total)
    {
      Price = price;
      Quantity = quantity;
      Total = total;
    }
    public string CheckPrice()
    {
     if (Quantity > Price)
     {
        return "3 loaves";
     }
     else
     {
        return "this isn't working";
     }
    }
  }
}