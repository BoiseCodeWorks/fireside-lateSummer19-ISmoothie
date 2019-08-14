
using SmoothieShack.Interfaces;

namespace SmoothieShack.Models
{
  public class Tshirt : IPurchaseable
  {
    public string Name { get; set; }
    public decimal Price { get; set; }

    public string size { get; set; }

    public string color { get; set; }
  }
}