using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VehicleManagementSystem.Models
{
    public class Car:Vehicle
    {
        public int Id { get; set; }
        [Display(Name = "Engine")]
        [Required(ErrorMessage = "Engine field is required.")]
        public string Engine { get; set; }
        [Display(Name = "Doors")]
        [Range(1, 4, ErrorMessage = "Number of doors must between 1 and 4.")]
        [Required(ErrorMessage = "Doors field is required.")]
        public int NumberOfDoors { get; set; }
        [Display(Name = "Wheels")]
        [Range(1, 4, ErrorMessage = "Number of wheels must between 1 and 4.")]
        [Required(ErrorMessage = "Wheels field is required.")]
        public int NumberOfWheels { get; set; }
        [Display(Name = "Body Type")]
        [Required(ErrorMessage = "Body type field is required.")]
        public string BodyType { get; set; }
        [Display(Name = "Registration")]
        [Required(ErrorMessage = "Registration field is required.")]
        public string Registration { get; set; }
    }
}