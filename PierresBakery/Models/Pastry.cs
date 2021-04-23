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
      get {return Amount * 5;}
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
  }
}