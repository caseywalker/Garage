using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Airplanes
{
  class F16 : Airplane
  {
    public int Munitions { get; set; }
    public F16(string color)
    {
      FuelCapacity = 100;
      CurrentFuel = 100;
      Color = color;
      Passengers = 2;
      GasMileage = 10;
      Speed = 0;
      Munitions = 4;
    }

    public void Airstrike()
    {
      if (Munitions > 0)
      {
        Console.WriteLine("F15 releases a munition.");
        Munitions -= 1;
      }
      else
      {
        Console.WriteLine("F15 out of munitions!");
      }
    }
  }
}
