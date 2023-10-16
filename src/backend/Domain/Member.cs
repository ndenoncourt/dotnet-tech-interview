namespace tech_interview_api.Domain;

public record Member
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public string? EmailAddress { get; set; }
    public string? PhoneNumber { get; set; }
}