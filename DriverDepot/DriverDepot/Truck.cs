using System;
namespace DriverDepot
{
    public class Truck : Vehicle
    {
        public int cargoCapacity;

        public Truck(string model, string make, int weight, string regNo, int cargoCapcity)
            : base (make, model, weight, regNo)
        {
            this.cargoCapacity = cargoCapcity;
        }

        //***************** Over Ride methods ******************************

        public override string GetCargoCapacity()
        {
            return this.cargoCapacity.ToString();
        }
        //***************** Over Ride methods ******************************

    }
}
