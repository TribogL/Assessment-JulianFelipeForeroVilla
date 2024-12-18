using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assessment_JulianFelipeForeroVilla.Models;
[Table("mourners")]
public class Mourner
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }


    [Column("first_name")]
    [MaxLength(250)]
    public string FirstName { get; set; }

    [Column("last_name")]
    [MaxLength(250)]
    public string LastName { get; set; }

    [Column("gender")]
    [MaxLength(100)]
    public string Gender { get; set; }

    [Column("age")]
    [Range(1, 150)]
    public int Age { get; set; }

    [Column("date_of_birth")]
    public DateTime DateOfBirth { get; set; }

    [Column("nationality")]
    [MaxLength(100)]
    public string? Nationality { get; set; }

    [Column("occupation")]
    [MaxLength(100)]
    public string? Occupation { get; set; }

    [Column("phone_number")]
    [MaxLength(150)]
    public string PhoneNumber { get; set; }

    [Column("address")]
    [MaxLength(250)]
    public string Address { get; set; }

    [Column("email")]
    [MaxLength(100)]
    public string Email { get; set; }

    [Column("password")]
    [MaxLength(250)]
    public string Password { get; set; }


    public Mourner()
    {

    }
    public Mourner(string firstName, string lastName, string gender, int age, DateTime dateOfBirth,
            string nationality, string occupation, string phoneNumber, string address, string email, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        Gender = gender;
        Age = age;
        DateOfBirth = dateOfBirth;
        Nationality = nationality;
        Occupation = occupation;
        PhoneNumber = phoneNumber;
        Address = address;
        Email = email;
        Password = password;
    }

}