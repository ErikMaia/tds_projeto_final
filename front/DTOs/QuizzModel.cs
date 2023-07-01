namespace api.core.DTOs;
public class QuizzDTO
{

    public int QuizzId { get; set; }

    public int Correct { get; set; }
    public string? Questions { get; set; }
    public string? FirstOption { get; set; }
    public string? SecondOption { get; set; }
    public string? ThirdOption { get; set; }
}
