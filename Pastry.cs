using System;
using System.Collections.Generic;

namespace Bakery.Pastry
{
  public class Pastries
  {
    // Private fields
    public float TotalPrice { get; set; }
    public int PastryPrice { get; set; }
    public float PastryPriceThreeOrMore { get; set; }

    // Constructor
    public Pastries()
    {
    TotalPrice = 0f;
    PastryPrice= 2;
    PastryPriceThreeOrMore = 5f/3;
    }

    public void PastryPriceCalculate (int NoOfPastries)
    {
      if (NoOfPastries ==3 || NoOfPastries > 3)
      {
        TotalPrice = NoOfPastries*PastryPriceThreeOrMore;
      } else
      {
        TotalPrice = NoOfPastries*(PastryPrice);
      }
    }

    public void PastryOrderGetter()
      {
        Console.WriteLine("");
        Console.WriteLine("What about Pastries? Try them they are good");
        Console.WriteLine("How many do you want? If you buy two or less, it is $2 a piece. For 3 it is $5");
        Console.WriteLine("How Many Pastries do you want?");
        string NoOfPastriesS = Console.ReadLine();
        int NoOfPastries = int.Parse(NoOfPastriesS);
        PastryPriceCalculate(NoOfPastries);
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Your total Price for " + NoOfPastries+ " Pastries" + " "+ "is "+ TotalPrice + " Dollars");
      }
  }
}