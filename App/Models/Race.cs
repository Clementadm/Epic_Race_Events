using System.ComponentModel.DataAnnotations;

namespace App.Models
{
    public class Race
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public DateTime EventDate { get; set; }

        // public TimeSpan EventBeginning { get; set; }

        [Required]
        public double Latitude { get; set; }

        [Required]
        public double Longitude { get; set; }
        public int MaxParticipant{ get; set; } = 15;
        public Uri? Picture { get; set; }
        public int RestrictedAge { get; set; } = 21;
        // public bool Result {get; set;}
    }
}