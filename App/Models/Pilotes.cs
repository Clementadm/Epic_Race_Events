using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
namespace App.Models
{
    public class Pilote
    {
        public int Id { get; set; }

        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
        [Required]
        public DateOnly Birthday { get; set; }
        [Required]
        // public MailAddress? Email  { get; set; }
        public string? Email  { get; set; }
        public string? Password  { get; set; }
    }
}