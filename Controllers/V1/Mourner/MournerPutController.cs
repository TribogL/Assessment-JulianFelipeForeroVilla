
using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Mourners;
[ApiController]
[Route("api/v1/Mourners")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Mourners")]
public class MournerPutController(IMournerRepository _MournerRepository) : MournerController(_MournerRepository)
{

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCustomer(int id, MournerDTO updateMourner)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var Mourner = await _MournerRepository.GetById(id);
        if (Mourner == null)
            return NotFound();

        await _MournerRepository.Update(id, updateMourner);

        // Obtiene los datos actualizados después de guardar
        var updatedMourner = await _MournerRepository.GetById(id);
        return Ok(updatedMourner);
    }


}
