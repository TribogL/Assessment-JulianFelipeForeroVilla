
using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Doctors;
[ApiController]
[Route("api/v1/Doctors")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("doctors")]
public class DoctorPostController(IDoctorRepository _DoctorRepository) : DoctorController(_DoctorRepository)
{
    [HttpPost]
    public async Task<IActionResult> AddDoctor(DoctorDTO newDoctor)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        await _DoctorRepository.Create(newDoctor);

        return Ok("Doctor added successfully.");
    }
}