

using Assessment_JulianFelipeForeroVilla.Data;
using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Models;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Assessment_JulianFelipeForeroVilla.Services;
public class RoleServices : IRoleRepository
{
private readonly ApplicationDbContext _context;

    public RoleServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Role> Create(RoleDTO RoleDTO)
    {
        var Role = new Role(RoleDTO.Name, RoleDTO.Description);
        _context.Roles.Add(Role);
        await _context.SaveChangesAsync();
        return Role;
    }

    public async Task Delete(int id)
    {
        var Role = await GetById(id);
        if (Role != null)
        {
            _context.Roles.Remove(Role);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Role>> GetAll()
    {
        return await _context.Roles.ToListAsync();
    }

    public async Task<Role?> GetById(int id)
    {
        return await _context.Roles.FindAsync(id);
    }

    public async Task<IEnumerable<Role>> GetByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return await GetAll();
        }

        return await _context.Roles
    .Where(pc => pc.Name.Contains(keyword) || pc.Description.Contains(keyword))
    .ToListAsync();

    }

    
    public async Task<bool> CheckExistence(int id)
    {
        try
        {
            return await _context.Roles.AnyAsync(u => u.Id == id);
        }
        catch (Exception exi)
        {
            throw new Exception("ocurrio un error a la hora de busacar el rol", exi);
        }
    }

}