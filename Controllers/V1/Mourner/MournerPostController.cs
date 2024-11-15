
using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Mourners;
[ApiController]
[Route("api/v1/Mourners")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Mourners")]
public class MournerPostController(IMournerRepository _MournerRepository) : MournerController(_MournerRepository)
{
    [HttpPost]
    public async Task<IActionResult> AddMourner(MournerDTO newMourner)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _MournerRepository.Create(newMourner);

        return Ok("Mourner added successfully.");
    }
}