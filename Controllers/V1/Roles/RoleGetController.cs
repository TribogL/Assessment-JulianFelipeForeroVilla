
using Assessment_JulianFelipeForeroVilla.Models;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Roles;
[ApiController]
[Route("api/v1/roles")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("roles")]
public class RoleGetController(IRoleRepository _RoleRepository) : RoleController(_RoleRepository)
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Role>>> GetAll()
    {
        var Role = await _RoleRepository.GetAll();

        return Ok(Role);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Role>> GetById(int id)
    {
        var Role = await _RoleRepository.GetById(id);

        if (Role == null)
        {
            return NotFound();
        }
        return Ok(Role);
    }

    [HttpGet("search/{keyword}")]
    public async Task<ActionResult<IEnumerable<Role>>> SearchByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return BadRequest("La palabra clave no puede estar vacia");
        }

        var Role = await _RoleRepository.GetByKeyword(keyword);

        if (!Role.Any())
        {
            return NotFound("no se encontraron roles con concidencias");
        }

        return Ok(Role);
    }
}
