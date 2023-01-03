using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Actor
{
    [Key]
    public int ActorId { get; set; }
    public string FullName { get; set; }
    public int Gender { get; set; }
    public int BirthYear { get; set; }
    public int DeathYear { get; set; }

    public List<Cast> Casts { get; set; }
}
