using System.ComponentModel.DataAnnotations;

namespace Afleveringsopgave.Models
{
    public class ShoppingList
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Indtast venligst en vare")]
        public string? Item { get; set; }
        [Required(ErrorMessage = "Indtast venligst et antal")]
        public int? Amount { get; set; }
        [Required(ErrorMessage = "Indtast venligst en afdeling")]
        public string? Location { get; set; }
    }
}
