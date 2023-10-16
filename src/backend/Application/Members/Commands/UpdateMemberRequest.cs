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

public class UpdateMemberRequestHandler : IRequestHandler<UpdateMemberRequest>
{
    private readonly ApplicationDbContext context;
    public UpdateMemberRequestHandler(ApplicationDbContext context) => this.context = context;

    public Task<bool> Handle(UpdateMemberRequest request)
    {
        Member? memberToUpdate = context.Members.Find(request.Id);

        memberToUpdate.Name = request.Name;
        memberToUpdate.EmailAddress = request.EmailAddress;
        memberToUpdate.PhoneNumber = request.PhoneNumber;
        context.Members.Update(memberToUpdate);
        context.SaveChanges();

        return Task.FromResult(true);
    }
}