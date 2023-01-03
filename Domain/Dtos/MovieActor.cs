using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class MovieActor
{
    [Key]
    public int MovieId { get; set; }
    public string Title { get; set; }
    public int MovieYear { get; set; }
    public int CategoryId { get; set; }
    public string FullName { get; set; }

}
