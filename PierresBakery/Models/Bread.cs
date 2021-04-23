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
    //   set {TotalCost = value * 5;}
    //   get {}
      

      // Below is the code that works
      get {return Amount * 5;}
      set {;}
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

        int NewTotalCost = Convert.ToInt32(Math.Ceiling(Amount/1.5));
        return NewTotalCost;

        // Amount = Convert.ToInt32(Math.Floor(Amount/.66));
        // return Amount;
      }
      else
      {
        return Amount;
      }
    }
  }
}