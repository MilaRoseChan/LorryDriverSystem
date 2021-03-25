using System;
namespace DriverDepot
{
    public class Tanker : Vehicle
    {
        private int liquidCapacity;
        private string liquidType;

        public Tanker(string make, string model, int weight, string regNo, int liquidCapacity, string liquidType)
            : base(make, model, weight, regNo)
        {
            this.liquidCapacity = liquidCapacity;
            this.liquidType = liquidType;
        }
        //***************** Over Ride methods ******************************

        public override string GetLiquidCapacity()
        {
            return this.liquidCapacity.ToString();
        }

        public override string getLiquidType()
        {
            return this.getLiquidType();
        }
        //***************** Over Ride methods ******************************


    }
}
