
using Assessment_JulianFelipeForeroVilla.Models;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Doctors;
[ApiController]
[Route("api/v1/Doctors")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("doctors")]

public class DoctorGetController(IDoctorRepository _DoctorRepository) : DoctorController(_DoctorRepository)
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Doctor>>> GetAll()

    {
        var Doctor = await _DoctorRepository.GetAll();

        return Ok(Doctor);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Doctor>> GetById(int id)
    {
        var Doctor = await _DoctorRepository.GetById(id);

        if (Doctor == null)
        {
            return NotFound();
        }
        return Ok(Doctor);
    }

    [HttpGet("search/{keyword}")]
    public async Task<ActionResult<IEnumerable<Doctor>>> SearchByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return BadRequest("La palabra clave no puede estar vacia");
        }

        var Doctor = await _DoctorRepository.GetByKeyword(keyword);

        if (!Doctor.Any())
        {
            return NotFound("no se encontraron Categorias con concidencias");
        }

        return Ok(Doctor);
    }
}
