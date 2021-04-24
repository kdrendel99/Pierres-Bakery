using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery 
{
  public class Program
  {
    public static void Main()
    {
      int doubleNegative = 0;
      Console.WriteLine("Welcome to Pierres Bakery! We sell delicious loaves of homemade Bread and Pastries.");
      Console.WriteLine("We have a couple great deals going on today! For our bread loaves, if you buy two, you get one free!");
      Console.WriteLine("Would you like to purchase any bread today? [Yes] or [No]");
      string wantBread = Console.ReadLine();
      if (wantBread == "no" || wantBread == "No" || wantBread == "NO")
      {
        doubleNegative = 1;
        goto PastryOrder;
      }
      else if (wantBread == "yes" || wantBread == "Yes" || wantBread == "YES")
      {
        Console.WriteLine("Great! How many loaves would you like? Remember we offer a buy two get one free deal! Otherwise, it's $5 per loaf.");
        string breadAmountString = Console.ReadLine();
        int breadAmount;
        bool isNumerical = int.TryParse(breadAmountString, out breadAmount);
        if (isNumerical == false)
        {
          BadInput();
        }
        Bread breadOrder = new Bread(breadAmount);      
        Console.WriteLine("Sounds good. Your total for bread is $" + breadOrder.ApplyBogoDeal() + "!"); 
      }
      else 
      {
        BadInput();
      }
      PastryOrder: 
      Console.WriteLine("Awesome! Would you like to order any pastries? We're currently offering a 1 for $2, or 3 for $5 deal! [Yes] or [No]");
      string wantPastry = Console.ReadLine();
      if (wantPastry == "no" || wantPastry == "NO" || wantPastry == "No")
        {
          if (doubleNegative == 1)
          {
          Console.WriteLine("No worries! Feel free to stop by again soon. Goodbye!");
          }
          else 
          {
            Console.WriteLine("Great. Let's take you to checkout then.");
            Checkout();
          }
        }
      else if (wantPastry == "yes" || wantPastry == "Yes" || wantPastry == "YES")
      {
        Console.WriteLine("Awesome. How many pastries would you like?");
        string pastryAmountString = Console.ReadLine();
        int pastryAmount;
        bool isNumerical = int.TryParse(pastryAmountString, out pastryAmount);
        if (isNumerical == false)
        {
          BadInput();
        }
        Pastry pastryOrder = new Pastry(pastryAmount);      
        Console.WriteLine("Excellent. Your total for pastries is $" + pastryOrder.ApplyBogoDeal() + "!");
        Checkout();
      }
      else
      {
        BadInput();
      }
    }
    
    static void Checkout()
    {
      Console.WriteLine("This is the checkout function");
    }

    static void BadInput()
    {
      Console.WriteLine("Sorry, I couldn't quite understand your input. Please try again!");
      Main();
    }
  }
}