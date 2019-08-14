using SmoothieShack.Interfaces;

namespace SmoothieShack.Models
{
  public class Chachkie : IPurchaseable
  {
    public string Name { get; set; }
    public decimal Price { get; set; }
  }
}