using System.ComponentModel.DataAnnotations;
using App.Models;

namespace App.Controllers
{
    public class CreateVehicleRequest
    {
        // [Required]
        // public VehiclesCategories VehiclesCategorie { get; set; }
        

        [Required]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public List<Categorie> categories { get; set; }
        [Required]
        public int niveauDePuissance { get; set; }
        [Required]
        public int anneeDeContruction { get; set; }
        // [Required]
        // public Uri? VehiclePicture { get; set; }

// Des catégories (Super Car, Hyper Car, Japan Race Car, German Classics…) (requis)
    }
}