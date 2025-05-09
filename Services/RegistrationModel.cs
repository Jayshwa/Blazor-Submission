using System.ComponentModel.DataAnnotations;

namespace AdvancedBlazorComponents.Models
{
    public class RegistrationModel
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select an event.")]
        public string SelectedEvent { get; set; } = string.Empty;
    }
}