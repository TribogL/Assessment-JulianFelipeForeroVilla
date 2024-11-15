

using Assessment_JulianFelipeForeroVilla.Data;
using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Models;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Assessment_JulianFelipeForeroVilla.Services;
public class UserServices : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<User> Create(UserDTO UserDTO)
    {
        var User = new User(UserDTO.RoleId,UserDTO.FirstName, UserDTO.LastName, UserDTO.Gender, UserDTO.Age, UserDTO.DateOfBirth, UserDTO.Nationality, UserDTO.Occupation, UserDTO.PhoneNumber, UserDTO.Address, UserDTO.Email, UserDTO.Password);
        _context.Users.Add(User);
        await _context.SaveChangesAsync();
        return User;
    }

    public async Task Delete(int id)
    {
        var User = await GetById(id);
        if (User != null)
        {
            _context.Users.Remove(User);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<User>> GetAll()
    {
        return await _context.Users.ToListAsync();
    }

    public async Task<User?> GetById(int id)
    {
        return await _context.Users.FindAsync(id);
    }

    public async Task<IEnumerable<User>> GetByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return await GetAll();
        }

        return await _context.Users
    .Where(pc => pc.FirstName.Contains(keyword) || pc.LastName.Contains(keyword)||pc.Gender.Contains(keyword) || pc.Email.Contains(keyword) || pc.Nationality.Contains(keyword) || pc.Occupation.Contains(keyword) || pc.PhoneNumber.Contains(keyword) || pc.Address.Contains(keyword) || pc.Occupation.Contains(keyword))
    .ToListAsync();

    }

    public async Task Update(int id, UserDTO UserDTO)
    {
        var User = await GetById(id);
        if (User == null) return;

        User.FirstName = UserDTO.FirstName.ToLower().Trim();
        User.LastName = UserDTO.LastName.ToLower().Trim();
        User.Gender = UserDTO.Gender.ToLower().Trim();
        User.Age = UserDTO.Age;
        User.DateOfBirth = UserDTO.DateOfBirth;
        User.Nationality = UserDTO.Nationality.ToLower().Trim();
        User.PhoneNumber = UserDTO.PhoneNumber.ToLower().Trim();
        User.Address = UserDTO.Address.ToLower().Trim();
        User.Email = UserDTO.Email.ToLower().Trim();
        User.Password = UserDTO.Password;
        await _context.SaveChangesAsync();
    }
    public async Task<bool> CheckExistence(int id)
    {
        try
        {
            return await _context.Users.AnyAsync(u => u.Id == id);
        }
        catch (Exception exi)
        {
            throw new Exception("ocurrio un error a la hora de busacar la categoria", exi);
        }
    }
}
