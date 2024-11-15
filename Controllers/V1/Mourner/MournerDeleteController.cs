
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Mourners;
[ApiController]
[Route("api/v1/Mourners")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("Mourners")]
public class MournerDeleteController(IMournerRepository _MournerRepository) : MournerController(_MournerRepository)
{
    [HttpDelete("{id}")]

    public async Task<IActionResult> Delete(int id)
    {
        var category = await _MournerRepository.CheckExistence(id);

        if (category == false)
        {
            return NotFound();
        }

        await _MournerRepository.Delete(id);

        return NotFound();
    }
}