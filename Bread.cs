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

  // Getters and Setters for fields
  



  
}
}