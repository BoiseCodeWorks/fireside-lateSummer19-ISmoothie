using SmoothieShack.Interfaces;

namespace SmoothieShack.Models
{
  public class EnergyShot : IPurchaseable, ICanEats
  {
    public int Cals { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public EnergyShot(string n, decimal p, int c)
    {
      Name = n;
      Price = p;
      Cals = c;
    }
  }
}