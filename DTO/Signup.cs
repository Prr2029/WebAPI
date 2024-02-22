using System.ComponentModel.DataAnnotations;

namespace WebAPI.DTO
{
    public class Signup
    {
        [Required]
        public string? password { get; set; }
        [Required]
        public string? mobileNo { get; set; }
        [Required]
        [EmailAddress]
        public string? emailId { get; set; }
       
        
    }
}

