
using System.ComponentModel.DataAnnotations;

namespace Assessment_JulianFelipeForeroVilla.DTOs;
public class DoctorDTO
{
    // Basic information
    [Required]
    [MaxLength(250, ErrorMessage = "Your first name can not have more than 250 characters")]
    public string FirstName { get; set; }

    [Required]
    [MaxLength(250, ErrorMessage = "Your last name can not have more than 250 characters")]
    public string LastName { get; set; }

    [Required]
    public string Gender { get; set; }

    [Required]
    [Range(1, 150, ErrorMessage = "Your age must be between 1 and 150")]
    public int Age { get; set; }

    // Contact information
    public int SpecialtyId { get; set; }

    [Required]
    [MaxLength(150, ErrorMessage = "Your Status can not have more than 150 characters")]
    public string Status { get; set; }


    [Range(1, 300, ErrorMessage = "Your office must be between 1 and 300")]
    public int Office { get; set; }

    // credencials
    [Required]
    [MaxLength(100, ErrorMessage = "Your email can not have more than 100 characters")]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    public string Email { get; set; }

    [Required]
    [MinLength(8, ErrorMessage = "Your password must have at least 8 characters")]
    [MaxLength(250, ErrorMessage = "Your password can not have more than 250 characters")]
    public string Password { get; set; }
    

}
