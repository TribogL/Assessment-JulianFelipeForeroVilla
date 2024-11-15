
using Assessment_JulianFelipeForeroVilla.Controllers.V1.Appoiments;
using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Appointment
{
    [ApiController]
    [Route("api/v1/appointments")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("appointments")]
    public class AppointmentPutController(IAppointmentRepository _AppointmentRepository) : AppointmentController(_AppointmentRepository)
    {
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(int id, AppointmentDTO updateAppointment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Appointment = await _AppointmentRepository.GetById(id);
            if (Appointment == null)
                return NotFound();

            await _AppointmentRepository.Update(id, updateAppointment);

            // Obtiene los datos actualizados después de guardar
            var updatedAppointment = await _AppointmentRepository.GetById(id);
            return Ok(updatedAppointment);
        }
    }
}