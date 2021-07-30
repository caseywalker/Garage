using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage.Watercrafts
{
  abstract class Watercraft
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

    public void Anchoring()
    {
      Speed = 0;
    }
  }
}
