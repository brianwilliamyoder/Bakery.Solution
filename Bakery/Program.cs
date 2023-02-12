using Bakery.Models;
using System;

namespace Bakery 
{

  public class Program
  {

    public static void Main()
    {

      Console.WriteLine("Welcome to Brian's Bakery!");
      Console.WriteLine("How many loaves of bread would you like? Please enter an amount using the number pad.");
      string amountOfLoaves = Console.ReadLine();

      foreach (char element in amountOfLoaves)
        {
          if (char.IsLetter(element))
          {
            Console.WriteLine("It looks like your input included a letter. Please enter the amount using the number keypad and try again.");
            Main();
          }
        }

      int loafInt = int.Parse(amountOfLoaves);
      Console.WriteLine("And how many pastries would you like?");
      string amountOfPastries = Console.ReadLine();

      foreach (char element in amountOfPastries)
        {
          if (char.IsLetter(element))
          {
            Console.WriteLine("Whoops, it looks like your input included a letter. Please enter the amount using the number keypad and try again.");
            Main();
          }
        }
        
      int pastryInt = int.Parse(amountOfPastries);
      Pastry newPastry = new Pastry();
      Bread newBread = new Bread();
      int pastryTotal = newPastry.CalculatePastry(pastryInt);
      int breadTotal = newBread.CalculateBread(loafInt);
      int grandTotal = pastryTotal + breadTotal;
      Console.WriteLine("Your grand total for " + amountOfLoaves + " loaves of bread and " + amountOfPastries + " pastries is " + "$" + grandTotal);
      
    }
  }
}