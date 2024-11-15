
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assessment_JulianFelipeForeroVilla.Models;
[Table("specialties")]
public class Specialty
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

    public Specialty( string name, string description)
    {
        Name = name;
        Description = description;

    }

    public Specialty()
    {
    }

}
