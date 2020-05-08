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
    TotalPrice = 0;
    PastryPrice= 2;
    PastryPriceThreeOrMore = 5/3;
    }

    public void PastryPrice (int NoOfPastries)
    {
      if (NoOfPastries =>3)
      {
        TotalPrice = NoOfPastries*(PastryPrice);
      } else
      {
        TotalPrice = NoOfPastries*PastryPriceThreeOrMore;
      }
    
    }
  }
}