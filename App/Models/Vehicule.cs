namespace App.Models;

public class Vehicule
{
    public int ID {get; set;}
    public string Name { get; set; }
    public virtual List<Categorie> Categories { get; set; }
    public int NiveauDePuissance { get; set; }
    public int AnneeDeContruction { get; set; }
}