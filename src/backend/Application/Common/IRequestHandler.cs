namespace tech_interview_api.Application.Common;

public interface IRequestHandler<in TRequest, TResponse>
    where TRequest : IRequest<TResponse>
{
    Task<TResponse> Handle(TRequest request);
}

public interface IRequestHandler<in TRequest> : IRequestHandler<TRequest, bool>
    where TRequest : IRequest<bool> { }