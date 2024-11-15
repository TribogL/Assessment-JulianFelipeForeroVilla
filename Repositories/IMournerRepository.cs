
using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Models;

namespace Assessment_JulianFelipeForeroVilla.Repositories;
public interface IMournerRepository
{
    Task<IEnumerable<Mourner>> GetAll();
    Task<Mourner?> GetById(int id);
    Task<IEnumerable<Mourner>> GetByKeyword(string keyword);
    Task<Mourner> Create(MournerDTO MournerDTO);
    Task Update(int id, MournerDTO MournerDTO);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);

}
