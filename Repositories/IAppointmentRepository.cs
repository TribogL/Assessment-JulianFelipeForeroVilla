
using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Models;

namespace Assessment_JulianFelipeForeroVilla.Repositories;
public interface IAppointmentRepository
{
    Task<IEnumerable<Appointment>> GetAll();
    Task<Appointment?> GetById(int id);
    Task<IEnumerable<Appointment>> GetByKeyword(string keyword);
    Task<Appointment> Create(AppointmentDTO AppointmentDTO);
    Task Update(int id, AppointmentDTO AppointmentDTO);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);

}
