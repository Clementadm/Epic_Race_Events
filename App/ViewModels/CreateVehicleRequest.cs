using System.ComponentModel.DataAnnotations;
using App.Models;

namespace App.Controllers
{
    public class CreateVehicleRequest
    {
        [Required]
        public VehiclesCategories VehiclesCategorie { get; set; }
        
        [DataType(DataType.DateTime)]
        [Required]
        public DateTime VehicleConstructionDate { get; set; }
        [Required]
        public string VehicleBrand { get; set; }
        [Required]
        public string VehicleModel { get; set; }
        [Required]
        public string VehicleHorsePower { get; set; }
        [Required]
        public Pilote VehiclePilote { get; set; }
        [Required]
        public Uri? VehiclePicture { get; set; }

// Des catégories (Super Car, Hyper Car, Japan Race Car, German Classics…) (requis)
    }
}
    }
}