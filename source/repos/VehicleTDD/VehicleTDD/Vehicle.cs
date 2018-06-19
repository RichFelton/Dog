using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTDD
{
    public class Vehicle
    {

        public string GetName { get; set; }
        public string GetYear { get; set; }
        public string GetModel { get; set; }
        //public int GetMileage { get; set; }
        public double GetMPH { get; set; }
        public double GetDistance { get; set; }
        public int mileage;
        public int PassengerNumber { get; set; }
        public int GetPassNum { get; set; }
        public double distance;
        public double time;
        public string name;


        public Vehicle()
        {

        }

        public Vehicle(string name, string year, string model)
        {
            this.GetName = name;
            this.GetYear = year;
            this.GetModel = model;

        }

        //public double VehicleMileage(double GetMPH, double GetDistance)
        //{
        //    GetMileage = mileage;

        //}
        public double GetMileage(double distance, double time)
        {
            return (35);
        }

        public double GetMPH(double distance, double time)
        {

        }




    }
}
