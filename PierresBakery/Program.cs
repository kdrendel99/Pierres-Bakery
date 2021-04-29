using System;
using System.Collections.Generic;
using PierresBakery.Models;
namespace PierresBakery 
{
  public class Program
  {
    public static void Main()
    {
      int pastryAmount = 0;
      int breadAmount = 0;
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
        bool isNumerical = int.TryParse(breadAmountString, out breadAmount);
        Bread breadOrder = new Bread(breadAmount);
        if (isNumerical == false)
        {
          BadInput();
        }      
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
        bool isNumerical = int.TryParse(pastryAmountString, out pastryAmount);
        Pastry pastryOrder = new Pastry(pastryAmount);
        if (isNumerical == false)
        {
          BadInput();
        }     
        Console.WriteLine("Excellent. Your total for pastries is $" + pastryOrder.ApplyBogoDeal() + "!");
        Console.WriteLine("Let's take you to checkout.");
        Checkout();
      }
      else
      {
        BadInput();
      }
      void Checkout()
      {
        Bread finalBreadOrder = new Bread(breadAmount);
        Pastry finalPastryOrder = new Pastry(pastryAmount);
        Console.WriteLine("This is the checkout function");
        int finalCost = finalBreadOrder.ApplyBogoDeal() + finalPastryOrder.ApplyBogoDeal();
        Console.WriteLine("Your order is: "); 
        Console.WriteLine(breadAmount + " loaves of bread");
        Console.WriteLine(pastryAmount + " pastries");
        Console.WriteLine($"Your total is: ${finalCost}" );
      }
    }
    static void BadInput()
    {
      Console.WriteLine("Sorry, I couldn't quite understand your input. Please try again!");
      Main();
    }
  }
}