using App.Models;

namespace App.Data;

public static class AppDbContextExtension
{
    public static void Seed(this AppDbContext dbContext)
    {
        Categorie superCar = new Categorie()
        {
            id = 1,
            name = "Super Car"
        };
        Categorie italianClassic = new Categorie()
        {
            id = 2,
            name = "Italian Classic"
        };
        Categorie muscleCar = new Categorie()
        {
            id = 3,
            name = "Muscle Car"
        };
        Categorie hyperCar = new Categorie()
        {
            id = 4,
            name = "Hyper Car"
        };
        Categorie japanRaceCar = new Categorie()
        {
            id = 5,
            name = "Japan Race Car"
        };
        Categorie germanClassics = new Categorie()
        {
            id = 6,
            name = "German Classics"
        };
        Categorie sportCar = new Categorie()
        {
            id = 7,
            name = "Sport Car"
        };
        Categorie americanLegend = new Categorie()
        {
            id = 8,
            name = "American Legend"
        };
        Categorie highPerformanceSportCar = new Categorie()
        {
            id = 9,
            name = "High Performance Sport Car"
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
            id = 1,
            name = "Ferrari - F40 ",
            categories = new List<Categorie>(){superCar, italianClassic},
            niveauDePuissance = 7
        });
        dbContext.Vehicules.Add(new Vehicule()
        {
            id = 2,
            name = "Lamborghini - Huracan (2014)",
            categories = new List<Categorie>(){superCar},
            niveauDePuissance = 7
        });
        dbContext.Vehicules.Add(new Vehicule()
        {
            id = 3,
            name = "Ford - Mustang 67’",
            categories = new List<Categorie>(){muscleCar, americanLegend},
            niveauDePuissance = 7
        });
        dbContext.Vehicules.Add(new Vehicule()
        {
            id = 4,
            name = "Dodge - Charger R/T 2021",
            categories = new List<Categorie>(){muscleCar},
            niveauDePuissance = 3
        });
        dbContext.Vehicules.Add(new Vehicule()
        {
            id = 5,
            name = "Dodge - Charger R/T 2021",
            categories = new List<Categorie>(){muscleCar},
            niveauDePuissance = 5
        });
        dbContext.Vehicules.Add(new Vehicule()
        {
            id = 6,
            name = "Pagani - Huayra R (2018)",
            categories = new List<Categorie>(){hyperCar},
            niveauDePuissance = 9
        });
        dbContext.Vehicules.Add(new Vehicule()
        {
            id = 7,
            name = "Bugatti - Chiron (2019)",
            categories = new List<Categorie>(){hyperCar},
            niveauDePuissance = 10
        });
        dbContext.Vehicules.Add(new Vehicule()
        {
            id = 8,
            name = "Toyota - Supra Yakuza Edition (1995)",
            categories = new List<Categorie>(){japanRaceCar},
            niveauDePuissance = 7
        });
        dbContext.Vehicules.Add(new Vehicule()
        {
            id = 9,
            name = "Honda - S2000 Racing (2009)",
            categories = new List<Categorie>(){japanRaceCar, sportCar},
            niveauDePuissance = 6
        });
        dbContext.Vehicules.Add(new Vehicule()
        {
            id = 10,
            name = "BMW E30 ‘91",
            categories = new List<Categorie>(){germanClassics, sportCar},
            niveauDePuissance = 6
        });
        dbContext.Vehicules.Add(new Vehicule()
        {
            id = 11,
            name = "Porsche - 911 GT3 2007",
            categories = new List<Categorie>(){germanClassics, highPerformanceSportCar},
            niveauDePuissance = 7
        });
    }
}