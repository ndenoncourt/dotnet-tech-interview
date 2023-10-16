namespace tech_interview_api.Application.Members.Models;

public class MemberDto
{
    public int Id { get; set; }
    public required string Name { get; init; }
    public string? EmailAddress { get; init; }
    public string? PhoneNumber { get; init; }
}