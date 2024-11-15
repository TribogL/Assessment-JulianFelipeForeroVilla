
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Assessment_JulianFelipeForeroVilla.Models;
[Table("doctors")]
public class Doctor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }


    [Required]
    [Column("first_name")]
    [MaxLength(250)]
    public string FirstName { get; set; }

    [Required]
    [Column("last_name")]
    [MaxLength(250)]
    public string LastName { get; set; }

    [Column("specialty_id")]
    public int SpecialtyId { get; set; }

    [Column("office")]
    [Range(1,300)]
    public int Office { get; set; }

    [Required]
    [Column("Status")]
    [MaxLength(100)]
    public string Status { get; set; }

    [Column("gender")]
    [MaxLength(100)]
    public string Gender { get; set; }

    [Column("email")]
    [MaxLength(250)]
    public string Email { get; set; }

    [Column("password")]
    [MaxLength(250)]
    public string Password { get; set; }

    [ForeignKey("specialty_id")]
    public Specialty Specialty { get; set; }

    public Doctor()
    {
        
    }
    public Doctor(string firstName, string lastName, int specialtyId, int office, string status, string gender, string email, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        SpecialtyId = specialtyId;
        Office = office;
        Status = status;
        Gender = gender;
        Email = email;
        Password = password;
    }

    
}
