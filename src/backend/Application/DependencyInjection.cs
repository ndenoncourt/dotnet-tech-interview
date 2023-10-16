using tech_interview_api.Application.Members.Commands;

namespace tech_interview_api.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddTransient<GetMembersRequestHandler>();
        services.AddTransient<UpdateMemberRequestHandler>();
        services.AddTransient<CreateMemberRequestHandler>();

        return services;
    }
}