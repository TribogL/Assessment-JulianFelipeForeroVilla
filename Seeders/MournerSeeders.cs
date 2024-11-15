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
            .RuleFor(u => u.Id, f => f.IndexFaker + 1)
            .RuleFor(u => u.FirstName, f => f.Name.FirstName()) 
            .RuleFor(u => u.LastName, f => f.Name.LastName()) 
            .RuleFor(u => u.Age, f => f.Random.Number(18, 99)) 
            .RuleFor(u => u.PhoneNumber, f => f.Phone.PhoneNumber()) 
            .RuleFor(u => u.Address, f => f.Address.StreetAddress()) 
            .RuleFor(u => u.Gender, f => f.PickRandom(new[] { "Male", "Female", "Other" }))
            .RuleFor(u => u.Email, f => f.Internet.Email()) 
            .RuleFor(u => u.Password, f => f.Internet.Password(8, true)) 
            .RuleFor(u => u.DateOfBirth, f => f.Date.Past(80, DateTime.Now.AddYears(-18))); 

        return faker.Generate(count);
    }
}

