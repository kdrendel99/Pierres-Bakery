using System;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery {
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierres Bakery! We sell delicious loaves of homemade Bread and Pastries.");
      Console.WriteLine("We have a couple great deals going on today! For our bread loaves, if you buy two, you get one free!");
      Console.WriteLine("Would you like to purchase any bread today? [Yes] or [No]");
      string wantBread = Console.ReadLine();
      if (wantBread == "yes" || wantBread == "Yes" || wantBread == "YES")
      {
        Console.WriteLine("Great! How many loaves would you like? Remember we offer a buy two get one free deal! Otherwise, it's $5 per loaf.");
        int breadAmount = Int32.Parse(Console.ReadLine());
        Bread breadOrder = new Bread(breadAmount);      
        Console.WriteLine("Sounds good. Your total for bread is $" + breadOrder.ApplyBogoDeal() + "!"); 
      }
      else if (wantBread == "no" || wantBread == "No" || wantBread == "NO")
      {
        Console.WriteLine("Awesome! Would you like to order any pastries? We're currently offering a 1 for $2, or 3 for $5 deal!");
        string wantPastry = Console.ReadLine();
        if (wantPastry == "yes" || wantPastry == "Yes" || wantPastry == "YES")
        {
          Console.WriteLine("Awesome. How many pastries would you like? Remember we offer a 1/$2 and 3/$5 deal!");
          int pastryAmount = Int32.Parse(Console.ReadLine());
          Pastry pastryOrder = new Pastry(pastryAmount);      
          Console.WriteLine("Sounds good. Your total for pastries is $" + pastryOrder.ApplyBogoDeal() + "!");
          Checkout();
        }
        else if (wantPastry == "no" || wantPastry == "No" || wantPastry == "NO")
        {
          Console.WriteLine("No worries! Feel free to stop by again soon. Goodbye!");
        }
        else 
        {
          Console.WriteLine("Sorry, I couldn't quite understand your input. Please try again!");
          Main();
        }
      }
      else 
      {
        Console.WriteLine("Sorry, I couldn't quite understand your input. Please try again!");
        Main();
      }



    void Checkout()
    {
      Console.WriteLine("This is the checkout function");
      // Console.WriteLine("Your order is: " + breadOrder.ApplyBogoDeal() + "for bread, and " + pastryOrder.ApplyBogoDeal() + " for pastries!");
    }



      // int breadAmount = Int32.Parse(Console.ReadLine());
      // Bread breadOrder = new Bread(breadAmount);
      // Console.WriteLine(breadOrder.ApplyBogoDeal());
      // // Pastry pastryOrder = new Pastry();
    }
  }
}