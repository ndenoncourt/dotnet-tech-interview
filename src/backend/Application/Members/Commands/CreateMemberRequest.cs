using Microsoft.EntityFrameworkCore;
using tech_interview_api.Application.Common;
using tech_interview_api.Application.Members.Models;
using tech_interview_api.Domain;
using tech_interview_api.Infrastructure.Persistence;

namespace tech_interview_api.Application.Members.Commands;

public class CreateMemberRequest : IRequest
{
    public required string Name { get; init; }
    public string? EmailAddress { get; init; }
    public string? PhoneNumber { get; init; }
}

public class CreateMemberRequestHandler : IRequestHandler<CreateMemberRequest>
{
    private readonly ApplicationDbContext context;
    public CreateMemberRequestHandler(ApplicationDbContext context) => this.context = context;

    public async Task<bool> Handle(CreateMemberRequest request)
    {
        var count = context.Members
                .Select(member => new MemberDto
                {
                    Id = member.Id,
                    Name = member.Name,
                    EmailAddress = member.EmailAddress,
                    PhoneNumber = member.PhoneNumber
                })
                .Where(member => member.EmailAddress == request.EmailAddress)
                .Count();

        if (count == 0) {
            var member = new Member
            {
                Name = request.Name,
                EmailAddress = request.EmailAddress,
                PhoneNumber = request.PhoneNumber
            };

            await context.Members.AddAsync(member);
        }

        return await context.SaveChangesAsync() > 0;
    }
}