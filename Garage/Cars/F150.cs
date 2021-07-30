using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Cars
{
  class F150 : Car
  {
    public int TowCapacity { get; set; }
    public F150(string color)
    {
      FuelCapacity = 36;
      CurrentFuel = 36;
      Color = color;
      Passengers = 4;
      GasMileage = 19;
      Speed = 0;
      TowCapacity = 5000;
    }

    public void Tow(int payload)
    {
      if (payload < TowCapacity)
      {
        Console.WriteLine($"The truck is able to tow this load.");
      } else
      {
        Console.WriteLine($"The tow capacity of this truck is below the rating for this load.");
      }
    }
  }
}
