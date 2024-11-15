
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Mourners;
[ApiController]
[Route("api/v1/[controller]")]
public class MournerController(IMournerRepository _MournerRepository) : ControllerBase
{

    protected readonly IMournerRepository _MournerRepository = _MournerRepository;

}
