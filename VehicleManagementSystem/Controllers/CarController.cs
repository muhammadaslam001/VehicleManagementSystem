using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Repository;

namespace VehicleManagementSystem.Controllers
{
    public class CarController : Controller
    {
        
        public CarController()
        {
           
        }

        private IGenericRepository<Car> repository = null;
               
        public CarController(IGenericRepository<Car> _repository)
        {
            this.repository = _repository;
        }

        // GET: Car
        [HttpGet]
        public ActionResult Index()
        {
            var model = repository.GetAll();
            return View(model);
        }

        [HttpGet]
        public ActionResult AddCar()
        {
            ViewBag.CarMake = DataForDropDowns.CarMake();
            ViewBag.CarModel = DataForDropDowns.CarModel();
            ViewBag.BodyType = DataForDropDowns.CarBodyType();
            ViewBag.CarYear = DataForDropDowns.CarYear();
           
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddCar(Car carmodel)
        {
            if (ModelState.IsValid)
            {
                repository.Insert(carmodel);
                repository.Save();
                return RedirectToAction("Index");
            }

            return View();
        }

        [HttpGet]
        public ActionResult EditCar(int id)
        {
            
            Car car = repository.GetById(id);
               

            ViewData["CarMake"] = DataForDropDowns.CarMake().Select(i => new SelectListItem
            {
                Value = i.Value,
                Text = i.Text,
                Selected = true
            });

           
            ViewData["CarModel"] = DataForDropDowns.CarModel().Select(i => new SelectListItem()
            {
                Value = i.Value,
                Text = i.Text,
                Selected = true
            });
           

            ViewData["CarBodyType"] = DataForDropDowns.CarBodyType().Select(i => new SelectListItem
            {
                Value = i.Value,
                Text = i.Text,
                Selected = true
            });

           

            ViewData["CarYear"] = DataForDropDowns.CarYear().Select(i => new SelectListItem()
            {
                Text = i.Text,
                Value = i.Value,
                Selected = true
            });


            return View(car);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditCar(Car carmodel)
        {
            if (ModelState.IsValid)
            {
                repository.Update(carmodel);
                repository.Save();
                return RedirectToAction("Index");
            }

            return View(carmodel);
        }



        [HttpGet]
        public ActionResult Delete(int id)
        {
            repository.Delete(id);
            repository.Save();
            return RedirectToAction("Index");
        }

       
    }
}