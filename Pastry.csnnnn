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
  }
}