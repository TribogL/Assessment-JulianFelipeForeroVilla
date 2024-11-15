
using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Specialties
{
    [ApiController]
    [Route("api/v1/Specialties")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("Specialties")]
    public class SpecialtyPostController(ISpecialtyRepository _SpecialtyRepository) : SpecialtyController(_SpecialtyRepository)
    {
        [HttpPost]
        public async Task<IActionResult> AddSpecialty(SpecialtyDTO newSpecialty)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _SpecialtyRepository.Create(newSpecialty);

            return Ok("Specialty added successfully.");
        }
    }
}