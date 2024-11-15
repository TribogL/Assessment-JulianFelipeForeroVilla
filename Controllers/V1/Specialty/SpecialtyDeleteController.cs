
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Specialties
{
    [ApiController]
    [Route("api/v1/Specialties")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Specialties")]
    public class SpecialtyDeleteController(ISpecialtyRepository _SpecialtyRepository) : SpecialtyController(_SpecialtyRepository)
    {
         [HttpDelete("{id}")]

    public async Task<IActionResult> Delete(int id)
    {
        var category = await _SpecialtyRepository.CheckExistence(id);

        if (category == false)
        {
            return NotFound();
        }

        await _SpecialtyRepository.Delete(id);

        return NotFound();
    }
    }
}