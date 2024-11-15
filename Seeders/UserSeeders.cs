using Assessment_JulianFelipeForeroVilla.Models;
using Bogus;
using Microsoft.EntityFrameworkCore;

namespace Assessment_JulianFelipeForeroVilla.Seeders;
public class MournerSeeders
{
    public static void Seed(ModelBuilder modelBuilder)
    {
        var Mourners = GenerateMourners(10);
        var allMourners = Mourners.ToList();

        modelBuilder.Entity<Mourner>().HasData(allMourners);
    }

    private static IEnumerable<Mourner> GenerateMourners(int count)
    {
        var faker = new Faker<Mourner>()
            .RuleFor(u => u.Id, f => f.IndexFaker + 1) // IDs únicos para cada usuario
            .RuleFor(u => u.FirstName, f => f.Name.FirstName()) // Nombre aleatorio
            .RuleFor(u => u.LastName, f => f.Name.LastName()) // Apellido aleatorio
            .RuleFor(u => u.Age, f => f.Random.Number(18, 99)) // Edad aleatoria entre 18 y 99
            .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber()) // Número de teléfono
            .RuleFor(u => u.Address, f => f.Address.StreetAddress()) // Dirección aleatoria
            .RuleFor(u => u.Gender, f => f.PickRandom(new[] { "Male", "Female", "Other" })) // Género
            .RuleFor(u => u.RoleId, f => f.PickRandom(new[] { 1, 2 })) // Asignar RoleId aleatoriamente (1 = Patient, 2 = Doctor)
            .RuleFor(u => u.Email, f => f.Internet.Email()) // Email aleatorio
            .RuleFor(u => u.Password, f => f.Internet.Password(8, true)) // Contraseña segura de 8 caracteres o más
            .RuleFor(u => u.DateOfBirth, f => f.Date.Past(80, DateTime.Now.AddYears(-18))); // Fecha de nacimiento calculada

        return faker.Generate(count);
    }
}

