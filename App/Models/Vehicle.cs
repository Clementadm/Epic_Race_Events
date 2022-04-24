namespace App.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public VehiclesCategories VehiclesCategorie { get; set; }
        public DateTime ConstructionDate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string HorsePower { get; set; }
        public Pilote Pilote { get; set; }
        public Uri? Picture { get; set; }

// Des catégories (Super Car, Hyper Car, Japan Race Car, German Classics…) (requis)
    }
}