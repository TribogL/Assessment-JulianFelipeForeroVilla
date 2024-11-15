
using System.ComponentModel.DataAnnotations;

namespace Assessment_JulianFelipeForeroVilla.DTOs;

public class MournerDTO
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

    [Required]
    public DateTime DateOfBirth { get; set; }

    // Contact information
    [MaxLength(100, ErrorMessage = "Your nationality can not have more than 100 characters")]
    public string Nationality { get; set; }

    [MaxLength(100, ErrorMessage = "Your occupation can not have more than 100 characters")]
    public string Occupation { get; set; }

    [MaxLength(150, ErrorMessage = "Your phone number can not have more than 150 characters")]
    public string PhoneNumber { get; set; }

    [MaxLength(250, ErrorMessage = "Your address can not have more than 250 characters")]
    public string Address { get; set; }

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

