

using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Models;

namespace Assessment_JulianFelipeForeroVilla.Repositories;
public interface IUserRepository
{
    Task<IEnumerable<User>> GetAll();
    Task<User?> GetById(int id);
    Task<IEnumerable<User>> GetByKeyword(string keyword);
    Task<User> Create(UserDTO UserDTO);
    Task Update(int id, UserDTO UserDTO);
    Task Delete(int id);
    Task<bool> CheckExistence(int id);

}
