using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VehicleManagementSystem.Models
{
    public class Vehicle
    {

        [Required(ErrorMessage = "Please select make field.")]
        public string Make { get; set; }
        [Required(ErrorMessage = "Please select model field.")]
        public string Model { get; set; }
        [Required(ErrorMessage = "Please select year field.")]
        public string Year { get; set; }
    }
}