
using Assessment_JulianFelipeForeroVilla.Models;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Specialties;
[ApiController]
[Route("api/v1/Specialties")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Specialties")]
public class SpecialtyGetController(ISpecialtyRepository _SpecialtyRepository) : SpecialtyController(_SpecialtyRepository)
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Specialty>>> GetAll()
    {
        var Specialty = await _SpecialtyRepository.GetAll();

        return Ok(Specialty);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Specialty>> GetById(int id)
    {
        var Specialty = await _SpecialtyRepository.GetById(id);

        if (Specialty == null)
        {
            return NotFound();
        }
        return Ok(Specialty);
    }

    [HttpGet("search/{keyword}")]
    public async Task<ActionResult<IEnumerable<Specialty>>> SearchByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return BadRequest("La palabra clave no puede estar vacia");
        }

        var Specialty = await _SpecialtyRepository.GetByKeyword(keyword);

        if (!Specialty.Any())
        {
            return NotFound("no se encontraron Specialties con concidencias");
        }

        return Ok(Specialty);
    }
}
