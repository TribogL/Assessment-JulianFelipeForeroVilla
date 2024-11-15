
using Assessment_JulianFelipeForeroVilla.Models;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Mourners;
[ApiController]
[Route("api/v1/Mourners")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Mourners")]

public class MournerGetController(IMournerRepository _MournerRepository) : MournerController(_MournerRepository)
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Mourner>>> GetAll()

    {
        var Mourner = await _MournerRepository.GetAll();

        return Ok(Mourner);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Mourner>> GetById(int id)
    {
        var Mourner = await _MournerRepository.GetById(id);

        if (Mourner == null)
        {
            return NotFound();
        }
        return Ok(Mourner);
    }

    [HttpGet("search/{keyword}")]
    public async Task<ActionResult<IEnumerable<Mourner>>> SearchByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return BadRequest("La palabra clave no puede estar vacia");
        }

        var Mourner = await _MournerRepository.GetByKeyword(keyword);

        if (!Mourner.Any())
        {
            return NotFound("no se encontraron Categorias con concidencias");
        }

        return Ok(Mourner);
    }
}
