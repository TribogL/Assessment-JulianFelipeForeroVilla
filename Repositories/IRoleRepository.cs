
using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Models;

namespace Assessment_JulianFelipeForeroVilla.Repositories;
public interface IRoleRepository
{

    Task<IEnumerable<Role>> GetAll();
    Task<Role?> GetById(int id);
    Task<IEnumerable<Role>> GetByKeyword(string keyword);
    Task<Role> Create(RoleDTO roleDTO);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);

}
