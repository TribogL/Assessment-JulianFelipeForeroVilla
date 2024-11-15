using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_JulianFelipeForeroVilla.DTOs;
public class RoleDTO
{
    [Required]
    [MaxLength(250, ErrorMessage = "The name can not have more than 250 characters")]
    public string Name { get; set; }

    [Required]
    [MaxLength(500, ErrorMessage = "The description can not have more than 500 characters")]
    public string? Description { get; set; }
}
