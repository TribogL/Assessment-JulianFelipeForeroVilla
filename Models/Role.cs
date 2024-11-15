
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assessment_JulianFelipeForeroVilla.Models;
[Table("roles")]
public class Role
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    [MaxLength(250)]
    public string Name { get; set; }

    [Column("description")]
    [MaxLength(250)]
    public string Description { get; set; }

    public Role( string name, string description)
    {
        Name = name;
        Description = description;

    }

    public Role()
    {
    }

}
