using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Appoiments;
[ApiController]
[Route("api/v1/appointments")]
public class AppointmentController(IAppointmentRepository _AppointmentRepository) : ControllerBase
{

     protected readonly IAppointmentRepository _AppointmentRepository = _AppointmentRepository;

}
