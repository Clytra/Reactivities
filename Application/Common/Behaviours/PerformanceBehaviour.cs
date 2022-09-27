using Application.Common.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace Application.Common.Behaviours
{
    public class PerformanceBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        private readonly ILogger _logger;
        private readonly Stopwatch _timer;
        private readonly ICurrentUserService _currentUserService;

        public PerformanceBehaviour(ILogger<TRequest> logger, ICurrentUserService currentUserService)
        {
            _timer = new Stopwatch();
            _logger = logger;
            _currentUserService = currentUserService;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            _timer.Start();

            var response = await next();

            _timer.Stop();

            var elapsed = _timer.ElapsedMilliseconds;

            if (elapsed > 500)
            {
                var resquestName = typeof(TRequest).Name;
                var userId = _currentUserService.UserId ?? string.Empty;

                _logger.LogInformation("Reactivities Long Running Request: {Name} ({elapsed} milliseconds) {@UserId} {@Request}",
                    resquestName, elapsed, userId, request);
            }

            return response;
        }
    }
}
