using Garage.Airplanes;
using Garage.Cars;
using Garage.Watercrafts;
using System;
using System.Collections.Generic;

namespace Garage
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Garage");

      List<Airplane> airplaneList = new List<Airplane>();
      List<Car> carList = new List<Car>();
      List<Watercraft> boatList = new List<Watercraft>();

      var strikeEagle = new F16("gray");
      var thunderBird = new F16("white");
      var falcon = new F16("red");
      airplaneList.Add(strikeEagle);
      airplaneList.Add(thunderBird);
      airplaneList.Add(falcon);


      var myTruck = new F150("silver");
      var nextTruck = new F150("black");
      var lastTruck = new F150("red");
      carList.Add(myTruck);
      carList.Add(nextTruck);
      carList.Add(lastTruck);

      var myBoat = new FishingBoat("red");
      var yourBoat = new FishingBoat("blue");
      boatList.Add(myBoat);
      boatList.Add(yourBoat);

      foreach (var aero in airplaneList)
      {
        aero.Flying(100, 200);
        Console.WriteLine($"Airplane is flying at {aero.Speed}, current fuel: {aero.CurrentFuel} of {aero.FuelCapacity} gallons.");
      }

      foreach (var truck in carList)
      {
        truck.Driving(50, 45);
        Console.WriteLine($"Vehicle is driving at {truck.Speed}, current fuel: {truck.CurrentFuel} of {truck.FuelCapacity} gallons.");
      }

      foreach (var boat in boatList)
      {
        boat.Driving(10, 2);
        Console.WriteLine($"Boat is driving at {boat.Speed}, current fuel: {boat.CurrentFuel} of {boat.FuelCapacity} gallons.");
      }

    }
  }
}
