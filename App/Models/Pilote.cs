namespace App.Models;
using System.ComponentModel.DataAnnotations;

public class Pilote
{
    public int id {get; set;}

    [Required]
    [MinLength(2)]
    [MaxLength(30)]
    public string firstName {get; set;} //(length: min 2 max: 30, requis)

    [Required]
    [MinLength(2)]
    [MaxLength(30)]
    public string name {get; set;} //(length: min 2 max: 30, requis)

    [Required]
    [DataType(DataType.Date)]
    public DateOnly birthday {get; set;} //(requis, type date only)

    [Required]
    [EmailAddress]
    public string email {get; set;} //(requis, unique, type mail)

    [Required]
    public string password {get; set;} //(requis)
    //Des véhicules possédés 
    //Des courses auxquelles il a / va participer (vide par défaut)

}