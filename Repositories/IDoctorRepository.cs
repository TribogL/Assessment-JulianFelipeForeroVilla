
using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Models;

namespace Assessment_JulianFelipeForeroVilla.Repositories;
public interface IDoctorRepository
{
    Task<IEnumerable<Doctor>> GetAll();
    Task<Doctor?> GetById(int id);
    Task<IEnumerable<Doctor>> GetByKeyword(string keyword);
    Task<Doctor> Create(DoctorDTO DoctorDTO);
    Task Update(int id, DoctorDTO DoctorDTO);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);

}
