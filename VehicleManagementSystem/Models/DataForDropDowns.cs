using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VehicleManagementSystem.Models
{
    public class DataForDropDowns
    {
        private static List<SelectListItem> carMakeList = null; 
        private static List<SelectListItem> carModelList = null;
        private static List<SelectListItem> carBodyTypeList = null;
        private static List<SelectListItem> carYearList = null;
        
        public static List<SelectListItem> CarMake()
        {
           carMakeList  = new List<SelectListItem>
            {
                new SelectListItem {Value="Audi",Text="Audi" },
                new SelectListItem {Value="Toyota",Text="Toyota" },
                new SelectListItem {Value="Holden",Text="Holden" },
                new SelectListItem {Value="BMW",Text="BMW" },
                new SelectListItem {Value="Ford",Text="Ford" }
            };
            return carMakeList;
        }

        
        public static List<SelectListItem> CarModel()
        {
           carModelList = new List<SelectListItem>
            {
                 new SelectListItem {Value="Allroad",Text="Allroad" },
                new SelectListItem {Value="Camry",Text="Camry" },
                new SelectListItem {Value="Barina",Text="Barina" },
                new SelectListItem {Value="3 Series",Text="3 Series" },
                new SelectListItem {Value="Focus",Text="Focus" }
            };
            return carModelList;
        }

        
        public static List<SelectListItem> CarBodyType()
        {
          carBodyTypeList  = new List<SelectListItem>()
            {
                new SelectListItem {Value="Sedan",Text="Sedan" },
                new SelectListItem {Value="Hatch",Text="Hatch" }
            };
            return carBodyTypeList;
        }

        
        public static List<SelectListItem> CarYear()
        {
           carYearList = new List<SelectListItem>
            {
                new SelectListItem {Value="2015",Text="2015" },
                new SelectListItem {Value="2016",Text="2016" },
                new SelectListItem {Value="2017",Text="2017" },
                new SelectListItem {Value="2018",Text="2018" },
                new SelectListItem {Value="2019",Text="2019" },
                new SelectListItem {Value="2020",Text="2020" }
            };
            return carYearList;
        }
    }

}