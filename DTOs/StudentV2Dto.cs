namespace StudentApi.DTOs;
public class StudentV2Dto
{
    public int Id { get; set; }
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Group { get; set; } = "";
    public double GPA { get; set; }
    public bool IsActive { get; set; }
}
