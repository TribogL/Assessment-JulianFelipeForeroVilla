
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Doctors;
[ApiController]
[Route("api/v1/Doctors")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("doctors")]
public class DoctorDeleteController(IDoctorRepository _DoctorRepository) : DoctorController(_DoctorRepository)
{
    [HttpDelete("{id}")]

    public async Task<IActionResult> Delete(int id)
    {
        var category = await _DoctorRepository.CheckExistence(id);

        if (category == false)
        {
            return NotFound();
        }

        await _DoctorRepository.Delete(id);

        return NotFound();
    }
}