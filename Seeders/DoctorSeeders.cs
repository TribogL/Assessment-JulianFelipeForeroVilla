
using Assessment_JulianFelipeForeroVilla.Models;
using Bogus;
using Microsoft.EntityFrameworkCore;

namespace Assessment_JulianFelipeForeroVilla.Seeders;
public class DoctorSeeders
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var Doctors = GenerateDoctors(10);
        var allDoctors = Doctors.ToList();

        modelBuilder.Entity<Doctor>().HasData(allDoctors);
    }

    private static IEnumerable<Doctor> GenerateDoctors(int count)
    {
        var faker = new Faker<Doctor>()
            .RuleFor(u => u.Id, f => f.IndexFaker + 1) 
            .RuleFor(u => u.FirstName, f => f.Name.FirstName()) 
            .RuleFor(u => u.LastName, f => f.Name.LastName()) 
            .RuleFor(u => u.SpecialtyId, f => f.PickRandom(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }))
            .RuleFor(u => u.Office, f => f.Random.Int(1, 300))
            .RuleFor(u => u.Status, f => f.Company.CompanyName())
            .RuleFor(u => u.Gender, f => f.PickRandom(new[] { "Male", "Female", "Other" })) 
            .RuleFor(u => u.Email, f => f.Internet.Email()) 
            .RuleFor(u => u.Password, f => f.Internet.Password(8, true)); 

        return faker.Generate(count);
    }
}
