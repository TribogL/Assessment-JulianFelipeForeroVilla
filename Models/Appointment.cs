

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

    [Column("mourner_id")]
    public int MournerId { get; set; }

    [Column("doctor_id")]
    public int DoctorId { get; set; }

    [Column("appointment_date")]
    public DateTime AppointmentDate { get; set; }

    [Column("appointment_time")]
    public TimeSpan AppointmentTime { get; set; }

    [Column("status")]
    public string Status { get; set; }

    [Column("reason")]
    [MaxLength(250)]
    public string Reason { get; set; }

    // freingkeys for navigation properties
    [ForeignKey("role_id")]
    public Mourner Mourner { get; set; }

    [ForeignKey("doctor_id")]
    public Doctor Doctor { get; set; }

    public Appointment(int mournerId, int doctorId, DateTime appointmentDate, TimeSpan appointmentTime, string status, string reason)
    {
        MournerId = mournerId;
        DoctorId = doctorId;
        AppointmentDate = appointmentDate;
        AppointmentTime = appointmentTime;
        Status = status;
        Reason = reason;

    }
}
