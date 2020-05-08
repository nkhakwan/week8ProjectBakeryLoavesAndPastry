using System;
using System.Collections.Generic;

namespace Bakery.Bread
{
public class Bread
{
  // Private fields
  //public int NoOfLoaves { get; set; }
  public int TotalPrice { get; set; }
  public int LoavePrice { get; set; }
  

  // Constructor
  public Bread()
  {
  //NoOfLoaves = 0;
  TotalPrice = 0;
  LoavePrice = 5;
  }

  public int BreadPrice (int NoOfLoaves)
  {
   int NumberOfTwoLoavesSets = NoOfLoaves/2;
   int TotalLoaves = NoOfLoaves + NumberOfTwoLoavesSets;
   TotalPrice = NoOfLoaves*LoavePrice;
  }

  // Getters and Setters for fields
  



  
}
}