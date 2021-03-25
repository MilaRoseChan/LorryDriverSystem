using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DriverDepot
{
    public class Vehicle
    {
        public List<History> vehicleHistory;
        protected string make;
        protected string model;
        protected int weight;
        protected string regNo;

        public Vehicle(string make, string model, int weight, string regNo)
        {
            this.make = make;
            this.model = model;
            this.weight = weight;
            this.regNo = regNo;
            vehicleHistory = new List<History>();
        }
        //call vehicle history comments from History class.
        public void GetHistory()
        {
            foreach (History history in vehicleHistory)
            {
                Console.Write(history.getComments());
            }
        }

        public string GetMake()
        {
            return make;

        }

        public string GetModel()
        {
            return model;
        }

        public int GetWeight()
        {
            return weight;
        }

        public string GetRegNo()
        {
            return regNo;
        }

        public void AddHistory(History history)
        {
            vehicleHistory.Add(history);
        }

        //*****************To be ovver ridden by sub classes ******************************

        public virtual string GetCargoCapacity()
        {
            return "--";
        }

        public virtual string GetLiquidCapacity()
        {
            return "--";
        }

        public virtual string getLiquidType()
        {
            return "--";
        }
        //*****************To be ovver ridden by sub classes **********************************

        //*****************To add history object to history list ******************************
        //*****************Call AddHistory method. ******************************


        public void AddHistory(DateTime date, string type, string comment)
        {
            AddHistory(new History(date, type, comment));
        }
        //*****************To add history object to history list ******************************



    }
}
