namespace Bakery.Models
{

 public class Bread
 {

  public int LoafCost {get;}

  public Bread()
  {
    LoafCost = 5;
  }

  public int CalculateBread(int amount)
  {
    int loafCost = LoafCost;
    int totalCost = 0;

    for (int i = 1; i <= amount; i++)
    {
      if (i % 2 == 0)
      {
        continue;
      }
      totalCost += loafCost;
    }
  return totalCost;
  }
 }

 public class Pastry
 {
  public int PastryCost {get;}

  public Pastry()
  {
    PastryCost = 2;
  }

  public int CalculatePastry(int amount)
  {
      int pastryCost = PastryCost;
      int totalCost = 0;
      for (int i = 1; i <= amount; i++)
    {
       if (i % 3 == 0)
      {
        continue;
      }
      totalCost += PastryCost;
    }
  return totalCost;
  }
 }
}


