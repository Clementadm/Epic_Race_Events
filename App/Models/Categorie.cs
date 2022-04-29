namespace App.Models;

public class Categorie
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string? Descsription { get; set; }
    public string? ImageUrl { get; set; }
    public string? Couleur { get; set; }
    public virtual List<Vehicule> Vehicules { get; set; }
}