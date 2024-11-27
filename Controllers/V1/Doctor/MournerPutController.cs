
using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Doctors;
[ApiController]
[Route("api/v1/Doctors")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("doctors")]
public class DoctorPutController(IDoctorRepository _DoctorRepository) : DoctorController(_DoctorRepository)
{

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateCustomer(int id, DoctorDTO updateDoctor)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var Doctor = await _DoctorRepository.GetById(id);
        if (Doctor == null)
            return NotFound();

        await _DoctorRepository.Update(id, updateDoctor);

        // Obtiene los datos actualizados después de guardar
        var updatedDoctor = await _DoctorRepository.GetById(id);
        return Ok(updatedDoctor);
    }


}
