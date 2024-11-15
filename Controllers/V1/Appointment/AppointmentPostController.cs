using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_JulianFelipeForeroVilla.Controllers.V1.Appoiments;
using Assessment_JulianFelipeForeroVilla.DTOs;
using Assessment_JulianFelipeForeroVilla.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_JulianFelipeForeroVilla.Controllers.V1.Appointment;
    [ApiController]
    [Route("api/v1/appointments")]
    [ApiExplorerSettings(GroupName = "v1")]
    [Tags("appointments")]
    public class AppointmentPostController(IAppointmentRepository _AppointmentRepository) : AppointmentController(_AppointmentRepository)
    {
        [HttpPost]
        public async Task<IActionResult> AddAppointment(AppointmentDTO newAppointment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _AppointmentRepository.Create(newAppointment);

            return Ok("Appointment added successfully.");
        }
    }
