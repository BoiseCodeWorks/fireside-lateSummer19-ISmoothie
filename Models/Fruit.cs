using SmoothieShack.Interfaces;

namespace SmoothieShack.Models
{
  public class Fruit : ICanEats, IPurchaseable
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Cals { get; set; }

    public Fruit(string n, decimal p, int c)
    {
      Name = n;
      Price = p;
      Cals = c;
    }
  }
}