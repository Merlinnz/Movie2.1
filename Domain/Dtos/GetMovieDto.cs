namespace Domain.Dtos;

public class GetMovieDto
{
    
    public int MovieId { get; set; }
    public string Title { get; set; }
    public int MovieYear { get; set; }
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
}
