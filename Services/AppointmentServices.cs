using Assessment_JulianFelipeForeroVilla.Data;
using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Models;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.EntityFrameworkCore;


namespace Assessment_JulianFelipeForeroVilla.Services;
public class AppointmentServices : IAppointmentRepository
{
    private readonly ApplicationDbContext _context;

    public AppointmentServices(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Appointment> Create(AppointmentDTO AppointmentDTO)
    {
        var Appointment = new Appointment(AppointmentDTO.MournerId, AppointmentDTO.DoctorId, AppointmentDTO.AppointmentDateTime, AppointmentDTO.Status, AppointmentDTO.Reason);
        _context.Appointments.Add(Appointment);
        await _context.SaveChangesAsync();
        return Appointment;
    }

    public async Task Delete(int id)
    {
        var Appointment = await GetById(id);
        if (Appointment != null)
        {
            _context.Appointments.Remove(Appointment);
            await _context.SaveChangesAsync();
        }
    }

    public async Task<IEnumerable<Appointment>> GetAll()

    {
        return await _context.Appointments.ToListAsync();
    }

    public async Task<Appointment> GetById(int id)
    {
        return await _context.Appointments.FindAsync(id);
    }

    public async Task<IEnumerable<Appointment>> GetByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return await GetAll();
        }

        return await _context.Appointments
    .ToListAsync();

    }

    public async Task Update(int id, AppointmentDTO AppointmentDTO)
    {
        var Appointment = await GetById(id);
        if (Appointment == null) return;

       
        await _context.SaveChangesAsync();
    }
    public async Task<bool> CheckExistence(int id)
    {
        try
        {
            return await _context.Appointments.AnyAsync(u => u.Id == id);
        }
        catch (Exception exi)
        {
            throw new Exception("ocurrio un error a la hora de busacar al medico", exi);
        }
    }
}
