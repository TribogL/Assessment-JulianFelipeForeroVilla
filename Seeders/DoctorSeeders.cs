
// using Assessment_JulianFelipeForeroVilla.Models;
// using Bogus;
// using Microsoft.EntityFrameworkCore;

// namespace Assessment_JulianFelipeForeroVilla.Seeders;
// public class DoctorSeeders
// {
//     public static void Seed(ModelBuilder modelBuilder)
//     {
//         var Doctors = GenerateDoctors(10);
//         var allDoctors = Doctors.ToList();

//         modelBuilder.Entity<Doctor>().HasData(allDoctors);
//     }

//     private static IEnumerable<Doctor> GenerateDoctors(int count)
//     {
//         var faker = new Faker<Doctor>()
//             .RuleFor(u => u.Id, f => f.IndexFaker + 1) // IDs únicos para cada usuario
//             .RuleFor(u => u.FirstName, f => f.Name.FirstName()) // Nombre aleatorio
//             .RuleFor(u => u.LastName, f => f.Name.LastName()) // Apellido aleatorio
//             .RuleFor(u => u.SpecialtyId, f => f.PickRandom(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 })) // Asignar SpecialtyId aleatoriamente
//             .RuleFor(u => u.Office, f => f.Random.Int(1, 300))
//             .RuleFor(u => u.Status, f => f.Company.CompanyName()) // Estado aleatorio
//             .RuleFor(u => u.Gender, f => f.PickRandom(new[] { "Male", "Female", "Other" })) // Género
//             .RuleFor(u => u.Email, f => f.Internet.Email()) // Email aleatorio
//             .RuleFor(u => u.Password, f => f.Internet.Password(8, true)); // Contraseña segura de 8 caracteres o más

//         return faker.Generate(count);
//     }
// }
