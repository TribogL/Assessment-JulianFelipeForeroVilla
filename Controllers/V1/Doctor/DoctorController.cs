
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Doctors;
[ApiController]
[Route("api/v1/[controller]")]
public class DoctorController(IDoctorRepository _DoctorRepository) : ControllerBase
{

    protected readonly IDoctorRepository _DoctorRepository = _DoctorRepository;

}
