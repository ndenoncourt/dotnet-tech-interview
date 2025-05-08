using System.Text.RegularExpressions;
using tech_interview_api.Application.Common;
using tech_interview_api.Domain;
using tech_interview_api.Infrastructure.Persistence;

namespace tech_interview_api.Application.Members.Commands;

public class UpdateMemberRequest : IRequest
{
    public int Id { get; init; }
    public string? Name { get; init; }
    public string? EmailAddress { get; init; }
    public string? PhoneNumber { get; init; }
}

public partial class UpdateMemberRequestHandler : IRequestHandler<UpdateMemberRequest>
{
    private readonly ApplicationDbContext context;
    public UpdateMemberRequestHandler(ApplicationDbContext context) => this.context = context;

    public async Task<bool> Handle(UpdateMemberRequest request)
    {
        if (request.PhoneNumber is not null && !Regexes.PhoneNumberRegex().IsMatch(request.PhoneNumber)) { throw new ArgumentException("Phone number must be in this format (xxx) xxx-xxxx"); }

        if (request.EmailAddress is not null && !Regexes.EmailRegex().IsMatch(request.EmailAddress)) { throw new ArgumentException("Email address is not valid"); }

        Member? memberToUpdate = await context.Members.FindAsync(request.Id);

        memberToUpdate.Name = request.Name;
        memberToUpdate.EmailAddress = request.EmailAddress;
        memberToUpdate.PhoneNumber = request.PhoneNumber;
        context.Members.Update(memberToUpdate);
        await context.SaveChangesAsync();

        return true;
    }
}