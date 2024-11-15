using System.ComponentModel.DataAnnotations;
namespace Assessment_JulianFelipeForeroVilla.DTOs;
public class AppointmentDTO
{
    [Required]
    public int MournerId { get; set; }
    [Required]
    public int DoctorId { get; set; }
    [Required]
    public int SpecialtyId { get; set; }
    [Required]

    public DateTime AppointmentDateTime { get; set; }

    [Required]
    [MaxLength(100, ErrorMessage = "The status can not have more than 100 characters")]
    public string Status { get; set; }


    [MaxLength(250, ErrorMessage = "The reason can not have more than 250 characters")]
    public string Reason { get; set; }

    [Required]
    public string Comment { get; set; }

}
