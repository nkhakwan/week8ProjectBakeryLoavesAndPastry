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
  //NoOfLoaves = 0;
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
        
        Console.WriteLine("Loaves are $5 a piece. Buy two and get one for free");
        Console.WriteLine("How Many Breads do you want?");
        string NoOfLoavesString = Console.ReadLine();
        int NoOfLoaves = int.Parse(NoOfLoavesString);
        BreadPrice(NoOfLoaves);
        Console.WriteLine("You have bought "+ NoOfLoaves + " Loaves. Your Total loaves with Promotion are " + TotalLoaves);
        Console.WriteLine("And the total Price you pay is "+ " " + TotalPrice);
      }

  // Getters and Setters for fields
  



  
}
}