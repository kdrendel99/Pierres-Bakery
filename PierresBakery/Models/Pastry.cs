using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int Amount { get; set; }

    public Pastry(int amount)
    {
      Amount = amount;
    }

    public int TotalCost
    {
      get {return Amount * 2;}
    }

    public bool BogoDeal()
    {
      if (TotalCost % 3 == 0)
      {
        return true;
      }
      else 
      {
        return false;
      }
    }

    public int ApplyBogoDeal()
    {
      Amount = Convert.ToInt32(Math.Ceiling(Amount/.66));
      return Amount;
    }
  }
}