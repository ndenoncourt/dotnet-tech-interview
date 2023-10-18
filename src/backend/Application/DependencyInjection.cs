using tech_interview_api.Application.Books.Commands;
using tech_interview_api.Application.Loans.Commands;
using tech_interview_api.Application.Members.Commands;

namespace tech_interview_api.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<GetMembersRequestHandler>();
        services.AddTransient<UpdateMemberRequestHandler>();
        services.AddTransient<CreateMemberRequestHandler>();
        services.AddTransient<GetBooksCommandHandler>();
        services.AddTransient<UpdateBookCommandHandler>();
        services.AddTransient<CreateBookCommandHandler>();
        services.AddTransient<RemoveBookCommandHandler>();
        services.AddTransient<GetLoansCommandHandler>();

        return services;
    }
}