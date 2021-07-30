using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Watercrafts
{
  class FishingBoat : Watercraft
  {
    public int LiveWell { get; set; }

    public FishingBoat(string color)
    {
      FuelCapacity = 15;
      CurrentFuel = 15;
      Color = color;
      Passengers = 2;
      GasMileage = 5;
      Speed = 0;
    }

    public void GoFish()
    {
      LiveWell++;
      Console.WriteLine($"Caught a fish! Live well now has {LiveWell} fish.");
    }
  }
}
