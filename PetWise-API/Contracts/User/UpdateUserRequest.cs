using System.ComponentModel.DataAnnotations;

namespace PetWise_API.Contracts.User
{
    public class UpdateUserRequest
    {
        public string? first_name { get; set; }
        public string? last_name { get; set; }
        public string? image_url { get; set; }
        public string? nickname { get; set; }
        public bool? has_completed_setup { get; set; }

        [MaxLength(20, ErrorMessage = "Contact number cannot exceed 20 characters.")]
        public string? contact_number { get; set; }

        [MaxLength(255, ErrorMessage = "Address cannot exceed 255 characters.")]
        public string? address { get; set; }
    }
}
