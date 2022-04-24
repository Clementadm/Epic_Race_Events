namespace App.Models;

public class Vehicule
{
    public int id {get; set;}
    public string name { get; set; }
    public List<Categorie> categories { get; set; }
    public int niveauDePuissance { get; set; }
}