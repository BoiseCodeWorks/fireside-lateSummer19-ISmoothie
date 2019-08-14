using System.Collections.Generic;

namespace SmoothieShack.Models
{
  public class Menu
  {
    public List<Fruit> AvailableFruit { get; set; } = new List<Fruit>();
    public List<EnergyShot> Shots { get; set; } = new List<EnergyShot>();
    public List<Chachkie> Souvenirs { get; set; } = new List<Chachkie>();
  }
}