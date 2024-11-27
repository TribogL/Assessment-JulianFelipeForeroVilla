using Assessment_JulianFelipeForeroVilla.Models;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Appoiments;
[ApiController]
[Route("api/v1/Appointments")]
[ApiExplorerSettings(GroupName = "v1")]
[Tags("appointments")]
public class AppoimentGetController(IAppointmentRepository _AppointmentRepository) : AppointmentController(_AppointmentRepository)
{
    [HttpGet]
   public async Task<ActionResult<IEnumerable<Models.Appointment>>> GetAll()
    {
        var Appointment = await _AppointmentRepository.GetAll();

        return Ok(Appointment);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Models.Appointment>> GetById(int id)
    {
        var Appointment = await _AppointmentRepository.GetById(id);

        if (Appointment == null)
        {
            return NotFound();
        }
        return Ok(Appointment);
    }

    [HttpGet("search/{keyword}")]
    public async Task<ActionResult<IEnumerable<Models.Appointment>>> SearchByKeyword(string keyword)
    {
        if (string.IsNullOrWhiteSpace(keyword))
        {
            return BadRequest("La palabra clave no puede estar vacia");
        }

        var Appointment = await _AppointmentRepository.GetByKeyword(keyword);

        if (!Appointment.Any())
        {
            return NotFound("no se encontraron Categorias con concidencias");
        }

        return Ok(Appointment);
    }
}
