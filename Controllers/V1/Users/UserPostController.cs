
using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Users;
[ApiController]
[Route("api/v1/users")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("users")]
public class UserPostController(IUserRepository _userRepository) : UserController(_userRepository)
{
    [HttpPost]
    public async Task<IActionResult> AddUser(UserDTO newUser)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _userRepository.Create(newUser);

        return Ok("User added successfully.");
    }
}