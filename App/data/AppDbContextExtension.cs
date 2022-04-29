using App.Models;

namespace App.Data;

public static class AppDbContextExtension
{
    public static void Seed(this AppDbContext dbContext)
    {
        Categorie superCar = new Categorie()
        {
            ID = 1,
            Name = "Super Car"
        };
        Categorie italianClassic = new Categorie()
        {
            ID = 2,
            Name = "Italian Classic"
        };
        Categorie muscleCar = new Categorie()
        {
            ID = 3,
            Name = "Muscle Car"
        };
        Categorie hyperCar = new Categorie()
        {
            ID = 4,
            Name = "Hyper Car"
        };
        Categorie japanRaceCar = new Categorie()
        {
            ID = 5,
            Name = "Japan Race Car"
        };
        Categorie germanClassics = new Categorie()
        {
            ID = 6,
            Name = "German Classics"
        };
        Categorie sportCar = new Categorie()
        {
            ID = 7,
            Name = "Sport Car"
        };
        Categorie americanLegend = new Categorie()
        {
            ID = 8,
            Name = "American Legend"
        };
        Categorie highPerformanceSportCar = new Categorie()
        {
            ID = 9,
            Name = "High Performance Sport Car"
        };
        dbContext.Categories.Add(superCar);
        dbContext.Categories.Add(italianClassic);
        dbContext.Categories.Add(muscleCar);
        dbContext.Categories.Add(hyperCar);
        dbContext.Categories.Add(japanRaceCar);
        dbContext.Categories.Add(germanClassics);
        dbContext.Categories.Add(sportCar);
        dbContext.Categories.Add(americanLegend);
        dbContext.Categories.Add(highPerformanceSportCar);
        
        dbContext.Vehicules.Add(new Vehicule()
        {
            ID = 1,
            Name = "Ferrari - F40 ",
            Categories = new List<Categorie>(){superCar, italianClassic},
            NiveauDePuissance = 7,
            AnneeDeContruction = 1987
        });
        dbContext.Vehicules.Add(new Vehicule()
        {
            ID = 2,
            Name = "Lamborghini - Huracan (2014)",
            Categories = new List<Categorie>(){superCar},
            NiveauDePuissance = 7,
            AnneeDeContruction = 2014
        });
        dbContext.Vehicules.Add(new Vehicule()
        {
            ID = 3,
            Name = "Ford - Mustang 67’",
            Categories = new List<Categorie>(){muscleCar, americanLegend},
            NiveauDePuissance = 7,
            AnneeDeContruction = 1967
        });
        dbContext.Vehicules.Add(new Vehicule()
        {
            ID = 4,
            Name = "Dodge - Charger R/T 2021",
            Categories = new List<Categorie>(){muscleCar},
            NiveauDePuissance = 3,
            AnneeDeContruction = 2021
        });
        dbContext.Vehicules.Add(new Vehicule()
        {
            ID = 5,
            Name = "Dodge - Charger R/T 2021",
            Categories = new List<Categorie>(){muscleCar},
            NiveauDePuissance = 5,
            AnneeDeContruction = 2021
        });
        dbContext.Vehicules.Add(new Vehicule()
        {
            ID = 6,
            Name = "Pagani - Huayra R (2018)",
            Categories = new List<Categorie>(){hyperCar},
            NiveauDePuissance = 9,
            AnneeDeContruction = 2018
        });
        dbContext.Vehicules.Add(new Vehicule()
        {
            ID = 7,
            Name = "Bugatti - Chiron (2019)",
            Categories = new List<Categorie>(){hyperCar},
            NiveauDePuissance = 10,
            AnneeDeContruction = 2019
        });
        dbContext.Vehicules.Add(new Vehicule()
        {
            ID = 8,
            Name = "Toyota - Supra Yakuza Edition (1995)",
            Categories = new List<Categorie>(){japanRaceCar},
            NiveauDePuissance = 7,
            AnneeDeContruction = 1995
        });
        dbContext.Vehicules.Add(new Vehicule()
        {
            ID = 9,
            Name = "Honda - S2000 Racing (2009)",
            Categories = new List<Categorie>(){japanRaceCar, sportCar},
            NiveauDePuissance = 6,
            AnneeDeContruction = 2009
        });
        dbContext.Vehicules.Add(new Vehicule()
        {
            ID = 10,
            Name = "BMW E30 ‘91",
            Categories = new List<Categorie>(){germanClassics, sportCar},
            NiveauDePuissance = 6,
            AnneeDeContruction = 1991
        });
        dbContext.Vehicules.Add(new Vehicule()
        {
            ID = 11,
            Name = "Porsche - 911 GT3 2007",
            Categories = new List<Categorie>(){germanClassics, highPerformanceSportCar},
            NiveauDePuissance = 7,
            AnneeDeContruction = 2007
        });
        dbContext.SaveChanges();
    }
}