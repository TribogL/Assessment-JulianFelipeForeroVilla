using Assessment_JulianFelipeForeroVilla.Data;
using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Models;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Assessment_JulianFelipeForeroVilla.Services;
public class DoctorServices : IDoctorRepository
{
    private readonly ApplicationDbContext _context;

    public DoctorServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Doctor> Create(DoctorDTO DoctorDTO)
    {
        var Doctor = new Doctor(DoctorDTO.FirstName, DoctorDTO.LastName, DoctorDTO.SpecialtyId, DoctorDTO.Office, DoctorDTO.Status, DoctorDTO.Gender, DoctorDTO.Email, DoctorDTO.Password);
        _context.Doctors.Add(Doctor);
        await _context.SaveChangesAsync();
        return Doctor;
    }

    public async Task Delete(int id)
    {
        var Doctor = await GetById(id);
        if (Doctor != null)
        {
            _context.Doctors.Remove(Doctor);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Doctor>> GetAll()
    {
        return await _context.Doctors.ToListAsync();
    }

    public async Task<Doctor?> GetById(int id)
    {
        return await _context.Doctors.FindAsync(id);
    }

    public async Task<IEnumerable<Doctor>> GetByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return await GetAll();
        }

        return await _context.Doctors
    .Where(pc => pc.FirstName.Contains(keyword) || pc.LastName.Contains(keyword) || pc.Gender.Contains(keyword) || pc.Email.Contains(keyword))
    .ToListAsync();

    }

    public async Task Update(int id, DoctorDTO DoctorDTO)
    {
        var Doctor = await GetById(id);
        if (Doctor == null) return;

        Doctor.FirstName = DoctorDTO.FirstName.ToLower().Trim();
        Doctor.LastName = DoctorDTO.LastName.ToLower().Trim();
        Doctor.Office = DoctorDTO.Office;
        Doctor.Gender = DoctorDTO.Gender.ToLower().Trim();
        Doctor.Email = DoctorDTO.Email.ToLower().Trim();
        Doctor.Password = DoctorDTO.Password;
        await _context.SaveChangesAsync();
    }
    public async Task<bool> CheckExistence(int id)
    {
        try
        {
            return await _context.Doctors.AnyAsync(u => u.Id == id);
        }
        catch (Exception exi)
        {
            throw new Exception("ocurrio un error a la hora de busacar al medico", exi);
        }
    }
}
