namespace App.Models;

public class Vehicule
{
    public int ID {get; set;}
    public string Name { get; set; }
    public virtual List<Categorie> Categories { get; set; }
    public int NiveauDePuissance { get; set; }
    public int AnneeDeContruction { get; set; }
}// using App.Controllers;

// namespace App.Models
// {
//     public class Vehicule
//     {
        // public int id {get; set;}
        // public string name { get; set; }
        // public List<Categorie> categories { get; set; }
        // public int niveauDePuissance { get; set; }
        // public int anneeDeContruction { get; set; }

        // public int Id { get; set; }
        // public VehiclesCategories VehiclesCategorie { get; set; }
        // public DateTime ConstructionDate { get; set; }
        // public string Brand { get; set; }
        // public string Model { get; set; }
        // public string HorsePower { get; set; }
        // public Pilote Pilote { get; set; }
        // public Uri? Picture { get; set; }

// Des catégories (Super Car, Hyper Car, Japan Race Car, German Classics…) (requis)
//     }
// }