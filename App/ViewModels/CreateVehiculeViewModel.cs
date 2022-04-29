using App.Models;

namespace App.ViewModels;

public class CreateVehiculeViewModel
{
    public List<Categorie> Categories { get; }
    public string HeaderTitle {get;}


    public CreateVehiculeViewModel(List<Categorie> categories, string headerTitle)
    {
        Categories = categories;
        HeaderTitle = headerTitle;
    }
}