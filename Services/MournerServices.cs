

using Assessment_JulianFelipeForeroVilla.Data;
using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Models;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Assessment_JulianFelipeForeroVilla.Services;
public class MournerServices : IMournerRepository
{
    private readonly ApplicationDbContext _context;

    public MournerServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Mourner> Create(MournerDTO MournerDTO)
    {
        var Mourner = new Mourner(MournerDTO.FirstName, MournerDTO.LastName, MournerDTO.Gender, MournerDTO.Age, MournerDTO.DateOfBirth, MournerDTO.Nationality, MournerDTO.Occupation, MournerDTO.PhoneNumber, MournerDTO.Address, MournerDTO.Email, MournerDTO.Password);
        _context.Mourners.Add(Mourner);
        await _context.SaveChangesAsync();
        return Mourner;
    }

    public async Task Delete(int id)
    {
        var Mourner = await GetById(id);
        if (Mourner != null)
        {
            _context.Mourners.Remove(Mourner);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Mourner>> GetAll()
    {
        return await _context.Mourners.ToListAsync();
    }

    public async Task<Mourner?> GetById(int id)
    {
        return await _context.Mourners.FindAsync(id);
    }

    public async Task<IEnumerable<Mourner>> GetByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return await GetAll();
        }

        return await _context.Mourners
    .Where(pc => pc.FirstName.Contains(keyword) || pc.LastName.Contains(keyword)||pc.Gender.Contains(keyword) || pc.Email.Contains(keyword) || pc.Nationality.Contains(keyword) || pc.Occupation.Contains(keyword) || pc.PhoneNumber.Contains(keyword) || pc.Address.Contains(keyword) || pc.Occupation.Contains(keyword))
    .ToListAsync();

    }

    public async Task Update(int id, MournerDTO MournerDTO)
    {
        var Mourner = await GetById(id);
        if (Mourner == null) return;

        Mourner.FirstName = MournerDTO.FirstName.ToLower().Trim();
        Mourner.LastName = MournerDTO.LastName.ToLower().Trim();
        Mourner.Gender = MournerDTO.Gender.ToLower().Trim();
        Mourner.Age = MournerDTO.Age;
        Mourner.DateOfBirth = MournerDTO.DateOfBirth;
        Mourner.Nationality = MournerDTO.Nationality.ToLower().Trim();
        Mourner.PhoneNumber = MournerDTO.PhoneNumber.ToLower().Trim();
        Mourner.Address = MournerDTO.Address.ToLower().Trim();
        Mourner.Email = MournerDTO.Email.ToLower().Trim();
        Mourner.Password = MournerDTO.Password;
        await _context.SaveChangesAsync();
    }
    public async Task<bool> CheckExistence(int id)
    {
        try
        {
            return await _context.Mourners.AnyAsync(u => u.Id == id);
        }
        catch (Exception exi)
        {
            throw new Exception("ocurrio un error a la hora de busacar la categoria", exi);
        }
    }
}
