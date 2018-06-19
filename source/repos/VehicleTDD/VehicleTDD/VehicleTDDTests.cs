using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Richard Felton
namespace VehicleTDD
{
    [TestFixture]
    class VehicleTDDTests
    {
        [Test]//Number 1
        public void VehicleTDD_Constructor()
        {
            var vehicle = new Vehicle();      //Arrange
            var result = Vehicle.GetName();      //Act
            Assert.That(result, Is.EqualTo(" ")); //Assert
        }
        [Test]//Number 2
        public void VehicleYear_Constructor()
        {
            var vehicle = new Vehicle();      //Arrange
            var result = vehicle.GetYear;      //Act
            Assert.That(result, Is.EqualTo(" ")); //Assert

        }

        [Test]//Number 3
        public void VehicleModel_Constructor()
        {
            var vehicle = new Vehicle();      //Arrange
            var result = vehicle.GetModel;      //Act
            Assert.That(result, Is.EqualTo(" ")); //Assert
        }

        [Test] //Number 4, 
        public void VehicleMileage_Constructor()
        {
        var vehicle = new Vehicle();
        var result = vehicle.GetMileage(vehicle.distance, vehicle.time);
        Assert.That(result, Is.EqualTo(35));
        }

        public void Create_Get_MPH_Mul_60()
        {
            var vehicle = new 
        }



        //[Test] //Number 5
        //public void VehiclePassengers_Constructor()
        //{
        //    var vehicle = new Vehicle();
        //    var result = vehicle.GetPassNum;
        //    Assert.That(result, Is.EqualTo(5));
        //}



    }
}//namespace
