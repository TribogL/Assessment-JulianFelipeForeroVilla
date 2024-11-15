
using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Models;

namespace Assessment_JulianFelipeForeroVilla.Repositories;
public interface ISpecialtyRepository
{

    Task<IEnumerable<Specialty>> GetAll();
    Task<Specialty?> GetById(int id);
    Task<IEnumerable<Specialty>> GetByKeyword(string keyword);
    Task<Specialty> Create(SpecialtyDTO SpecialtyDTO);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);

}
