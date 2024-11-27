using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assessment_JulianFelipeForeroVilla.Models;

[Table("appointments")]
public class Appointment
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [Column("mourner_id")]
    public int MournerId { get; set; }

    [Required]
    [Column("doctor_id")]
    public int DoctorId { get; set; }

    [Required]
    [Column("appointment_datetime")]
    public DateTime AppointmentDateTime { get; set; }

    [Required]
    [Column("status")]
    [MaxLength(100)]
    public string Status { get; set; }

    [Column("reason")]
    [MaxLength(250)]
    public string Reason { get; set; }

    // Foreign keys for navigation properties
    [ForeignKey("MournerId")]
    public Mourner Mourner { get; set; } 
    [ForeignKey("DoctorId")]
    public Doctor Doctor { get; set; }

    public Appointment()
    {
        
    }

    public Appointment(int mournerId, int doctorId, DateTime appointmentDateTime, string status, string reason)
    {
        MournerId = mournerId;
        DoctorId = doctorId;
        AppointmentDateTime = appointmentDateTime;
        Status = status ?? "Scheduled"; // Valor predeterminado si no se especifica
        Reason = reason;
    }
}
