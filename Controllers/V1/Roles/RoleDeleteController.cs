
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Roles
{
    [ApiController]
    [Route("api/v1/roles")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("roles")]
    public class RoleDeleteController(IRoleRepository _RoleRepository) : RoleController(_RoleRepository)
    {
         [HttpDelete("{id}")]

    public async Task<IActionResult> Delete(int id)
    {
        var category = await _RoleRepository.CheckExistence(id);

        if (category == false)
        {
            return NotFound();
        }

        await _RoleRepository.Delete(id);

        return NotFound();
    }
    }
}