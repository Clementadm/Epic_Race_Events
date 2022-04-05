using System.ComponentModel.DataAnnotations;

namespace App.ViewModels
{
    public class CreateRaceRequest
    {
        [Required(ErrorMessage = "Nom requis pour la course")]
        [MaxLength(30, ErrorMessage = "Trop long")]
        [MinLength(3, ErrorMessage = "Nom trop court ! Min : 3")]
        public string? RaceName { get; set; }

        [DataType(DataType.DateTime)]
        [Required]
        public DateTime RaceEventDate { get; set; }


        [DataType(DataType.Time)]
        [Required]
        public TimeSpan EventBeginning { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }
        [Required]
        public int MaxParticipant{ get; set; } = 15;

        [DataType(DataType.ImageUrl)]
        [Required]
        public Uri? Picture { get; set; }
        [Required]
        public int RestrictedAge { get; set; } = 21;
        [Required]
        public bool Result {get; set;}
    }
}