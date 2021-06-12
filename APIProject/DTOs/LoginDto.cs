using System.ComponentModel.DataAnnotations;

namespace APIProject.DTOs
{
    public class LoginDto
    {
        [Required]    
        public string Username { get; set; }
        [Required] 
        public string Password { get; set; }  
    }
}