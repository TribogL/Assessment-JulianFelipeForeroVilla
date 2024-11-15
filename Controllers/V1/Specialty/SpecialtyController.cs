
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Specialties;
[ApiController]
[Route("api/[controller]")]
public class SpecialtyController(ISpecialtyRepository _SpecialtyRepository) : ControllerBase
{

     protected readonly ISpecialtyRepository _SpecialtyRepository = _SpecialtyRepository;

}