using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Appoiments
{
    [ApiController]
    [Route("api/v1/appointments")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("appointments")]
    public class AppointmentDeleteController (IAppointmentRepository _AppointmentRepository) : AppointmentController(_AppointmentRepository)
    {
        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            var category = await _AppointmentRepository.CheckExistence(id);

            if (category == false)
            {
                return NotFound();
            }

            await _AppointmentRepository.Delete(id);

            return NotFound();
        }
    }
}