using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Roles;
[ApiController]
[Route("api/[controller]")]
public class RoleController(IRoleRepository _RoleRepository) : ControllerBase
{

     protected readonly IRoleRepository _RoleRepository = _RoleRepository;

}