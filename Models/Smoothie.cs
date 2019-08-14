using System.Collections.Generic;
using System.Linq;
using SmoothieShack.Interfaces;

namespace SmoothieShack.Models
{
  public class Smoothie : IPurchaseable
  {
    public string Name { get; set; }
    public decimal Price { get { return GetTotal(); } }
    public List<Fruit> Fruits { get; set; } = new List<Fruit>();
    public List<EnergyShot> Shots { get; set; } = new List<EnergyShot>();


    public decimal GetTotal()
    {
      return Fruits.Sum(f => f.Price) + Shots.Sum(s => s.Price);
    }

  }
}