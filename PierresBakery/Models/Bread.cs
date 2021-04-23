using System.Collections.Generic;
using System;
using System.Linq;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int Amount { get; set; }
    public Bread(int amount)
    {
      Amount = amount;
    }

    public int TotalCost
    {
      get {return Amount * 5;}
      // set {;}
    }

    public bool CheckTwo()
    {
      if (Amount >= 2)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public bool BogoDeal()
    {
      if (TotalCost % 2 == 0)
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
      if (CheckTwo())
      {
        Amount = Convert.ToInt32(Math.Floor(Amount/.66));
        return Amount;
      }
      else
      {
        return 0;
      }
    }
  }
}