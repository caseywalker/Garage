using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Cars
{
  abstract class Car
  {
    public int FuelCapacity { get; set; }
    public int CurrentFuel { get; set; }
    public string Color { get; set; }
    public int Passengers { get; set; }
    public int GasMileage { get; set; }
    public int Speed { get; set; }

    public void Refuel()
    {
      CurrentFuel = FuelCapacity;
    }

    public void Driving(int miles, int speed)
    {
      CurrentFuel -= (miles / GasMileage);
      Speed = speed;
    }

    public void Braking()
    {
      Speed = 0;
    }

  }
}
