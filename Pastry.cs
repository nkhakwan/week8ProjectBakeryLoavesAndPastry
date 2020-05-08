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
    //NoOfLoaves = 0;
    TotalPrice = 0f;
    PastryPrice= 2;
    PastryPriceThreeOrMore = 5f/3;
    }

    public void PastryPriceCalculate (int NoOfPastries)
    {
      if (NoOfPastries ==3 || NoOfPastries > 3)
      {
        Console.WriteLine("inside 3 or more and pastry Price before calc is " + PastryPriceThreeOrMore);
        TotalPrice = NoOfPastries*PastryPriceThreeOrMore;
        Console.WriteLine("inside 3 or more and Total Price after calc is " + TotalPrice);
      } else
      {
        TotalPrice = NoOfPastries*(PastryPrice);
      }
    
    }

    public void PastryOrderGetter()
      {
        
        
        Console.WriteLine("What about Pastries? How many do you want? If you buy two, it is $2 a piece. For 3 it is $5");
        Console.WriteLine("How Many Pastries do you want?");
        string NoOfPastriesS = Console.ReadLine();
        int NoOfPastries = int.Parse(NoOfPastriesS);
        PastryPriceCalculate(NoOfPastries);
        Console.WriteLine("Your total Price for " + NoOfPastries+ " Pastries" + " "+ "is "+ TotalPrice + " Dollars");
      }
  }
}