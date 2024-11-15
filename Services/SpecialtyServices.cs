
using Assessment_JulianFelipeForeroVilla.Data;
using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Models;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Assessment_JulianFelipeForeroVilla.Services;
public class SpecialtyServices : ISpecialtyRepository
{
private readonly ApplicationDbContext _context;

    public SpecialtyServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Specialty> Create(SpecialtyDTO SpecialtyDTO)
    {
        var Specialty = new Specialty(SpecialtyDTO.Name, SpecialtyDTO.Description);
        _context.Specialties.Add(Specialty);
        await _context.SaveChangesAsync();
        return Specialty;
    }

    public async Task Delete(int id)
    {
        var Specialty = await GetById(id);
        if (Specialty != null)
        {
            _context.Specialties.Remove(Specialty);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Specialty>> GetAll()
    {
        return await _context.Specialties.ToListAsync();
    }

    public async Task<Specialty?> GetById(int id)
    {
        return await _context.Specialties.FindAsync(id);
    }

    public async Task<IEnumerable<Specialty>> GetByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return await GetAll();
        }

        return await _context.Specialties
    .Where(pc => pc.Name.Contains(keyword) || pc.Description.Contains(keyword))
    .ToListAsync();

    }

    
    public async Task<bool> CheckExistence(int id)
    {
        try
        {
            return await _context.Specialties.AnyAsync(u => u.Id == id);
        }
        catch (Exception exi)
        {
            throw new Exception("ocurrio un error a la hora de busacar el rol", exi);
        }
    }

}