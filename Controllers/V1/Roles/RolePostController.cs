
using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Roles
{
    [ApiController]
    [Route("api/v1/roles")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("roles")]
    public class RolePostController(IRoleRepository _RoleRepository) : RoleController(_RoleRepository)
    {
        [HttpPost]
        public async Task<IActionResult> AddRole(RoleDTO newRole)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _RoleRepository.Create(newRole);

            return Ok("Role added successfully.");
        }
    }
}