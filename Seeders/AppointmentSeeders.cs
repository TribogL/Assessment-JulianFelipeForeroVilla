using Assessment_JulianFelipeForeroVilla.Models;
using Bogus;
using Microsoft.EntityFrameworkCore;

namespace Assessment_JulianFelipeForeroVilla.Seeders;
public class AppointmentSeeders
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        // Generar citas aleatorias
        var appointments = GenerateAppointments(20); // Genera 20 citas
        var allAppointments = appointments.ToList();

        modelBuilder.Entity<Appointment>().HasData(allAppointments);
    }

    private static IEnumerable<Appointment> GenerateAppointments(int count)
    {
        // IDs de pacientes y doctores existentes
        var patientIds = Enumerable.Range(1, 10); 
        var doctorIds = Enumerable.Range(1, 5);  

        var faker = new Faker<Appointment>()
            .RuleFor(a => a.Id, f => f.IndexFaker + 1)
            .RuleFor(a => a.MournerId, f => f.PickRandom(patientIds)) 
            .RuleFor(a => a.DoctorId, f => f.PickRandom(doctorIds))  
            .RuleFor(a => a.AppointmentDateTime, f => f.Date.Future(1))
            .RuleFor(a => a.Status, f => f.PickRandom(new[] { "Scheduled", "Completed", "Cancelled" })) 
            .RuleFor(a => a.Reason, f => f.Lorem.Sentence(5)); 

        return faker.Generate(count);
    }
}
