using System;
using System.Collections.Generic;

namespace Bakery.Bread
{
public class Loaves
{
  // Private fields
  //public int NoOfLoaves { get; set; }
  public int TotalPrice { get; set; }
  public int LoavePrice { get; set; }
  public int TotalLoaves { get; set;}

  // Constructor
  public Loaves()
  {
  TotalLoaves = 0;
  TotalPrice = 0;
  LoavePrice = 5;
  }

  public void BreadPrice (int NoOfLoaves)
  {
   int NumberOfTwoLoavesSets = NoOfLoaves/2;
   TotalLoaves = NoOfLoaves + NumberOfTwoLoavesSets;
   TotalPrice = NoOfLoaves*LoavePrice;
  }

  public void LoavesOrderGetter()
      {
        Console.WriteLine("");
        Console.WriteLine("Loaves are $5 a piece. Buy two and get one for free. How Many Loaves do you want?");
        string NoOfLoavesString = Console.ReadLine();
        int NoOfLoaves = int.Parse(NoOfLoavesString);
        BreadPrice(NoOfLoaves);
        Console.WriteLine("You bought "+ NoOfLoaves + " Loaves in the current order. Your Total loaves with Promotion are " + TotalLoaves);
        Console.WriteLine("And the total Price you pay for your current order of loaves is "+ " " + TotalPrice);
      }

  // Getters and Setters for fields
}
}