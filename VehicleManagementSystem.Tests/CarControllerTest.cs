using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Controllers;
using System.Collections.Generic;
using VehicleManagementSystem.Tests.Repository;
using System.Web.Mvc;

namespace VehicleManagementSystem.Tests
{
    [TestClass]
    public class CarControllerTest
    {
        Car car1 = null;
        Car car2 = null;
        Car car3 = null;
        Car car4 = null;


        List<Car> cars = null;
        InMemoryGenericRepository<Car> carRepo = null;
        CarController controller = null;

        public CarControllerTest()
        {
            car1 = new Car()
            {
                Id = 1,
                Make = "Make1",
                Model = "Model1",
                Year = "Year1",
                Engine = "Engine1",
                NumberOfDoors = 4,
                NumberOfWheels = 4,
                BodyType = "BodyType1",
                Registration = "Registration1"
            };
            car2 = new Car()
            {
                Id = 2,
                Make = "Make2",
                Model = "Model2",
                Year = "Year2",
                Engine = "Engine2",
                NumberOfDoors = 4,
                NumberOfWheels = 4,
                BodyType = "BodyType2",
                Registration = "Registration2"
            };
            car3 = new Car()
            {
                Id = 3,
                Make = "Make3",
                Model = "Model3",
                Year = "Year3",
                Engine = "Engine3",
                NumberOfDoors = 4,
                NumberOfWheels = 4,
                BodyType = "BodyType3",
                Registration = "Registration3"
            };
            car4 = new Car()
            {
                Id = 4,
                Make = "Make4",
                Model = "Model4",
                Year = "Year4",
                Engine = "Engine4",
                NumberOfDoors = 4,
                NumberOfWheels = 4,
                BodyType = "BodyType4",
                Registration = "Registration4"
            };

            cars = new List<Car>()
            {
               car1,car2,car3,car4
            };

            carRepo = new InMemoryGenericRepository<Car>(cars);
            controller = new CarController(carRepo);
        }

        [TestMethod]
        public void Index()
        {
            //Arrange
            ViewResult result = controller.Index() as ViewResult;

            //Act
            var model = (List<Car>)result.ViewData.Model;

            //Asser
            CollectionAssert.Contains(model, car1);
            CollectionAssert.Contains(model, car2);
            CollectionAssert.Contains(model, car3);
            CollectionAssert.Contains(model, car4);
        }

        [TestMethod]
        public void Create()
        {
            //Arrange - create car object
            Car newCar = new Car
            {
                Id = 4,
                Make = "Make New",
                Model = "Model New",
                Year = "Year New",
                Engine = "Engine New",
                NumberOfDoors = 4,
                NumberOfWheels = 4,
                BodyType = "BodyType New",
                Registration = "Registration New"
            };

            //Act - call the AddCar Action Method
            controller.AddCar(newCar);
            List<Car> carsList = (List<Car>)carRepo.GetAll();

            //Assert
            CollectionAssert.Contains(carsList, newCar);

        }
    }
}
