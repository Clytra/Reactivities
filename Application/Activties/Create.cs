using Application.Common.Interfaces;
using Application.Core;
using Domain.Entities;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.Activties
{
    public class Create
    {
        public class Command : IRequest<Result<Unit>>
        {
            public Activity Activity { get; set; }
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.Activity).SetValidator(new ActivityValidator());
            }
        }

        public class Handler : IRequestHandler<Command, Result<Unit>>
        {
            private readonly IDataContext _context;
            private readonly ICurrentUserService _currentUserService;
            private readonly UserManager<AppUser> _userManager;

            public Handler(IDataContext context, 
                ICurrentUserService currentUserService, 
                UserManager<AppUser> userManager)
            {
                _userManager = userManager;
                _context = context;
                _currentUserService = currentUserService;
            }

            public async Task<Result<Unit>> Handle(Command request, CancellationToken cancellationToken)
            {
                var userId = _currentUserService.UserId ?? string.Empty;
                string userName = string.Empty;

                // TODO Modify auditing user

                if (!string.IsNullOrEmpty(userId))
                {
                    //userName = await _userManager.GetUserName(userId);
                }

                var attendee = new ActivityAttendee
                {
                    //AppUser = user,
                    Activity = request.Activity,
                    IsHost = true
                };

                request.Activity.Attendees.Add(attendee);

                _context.Activities.Add(request.Activity);

                var result = await _context.SaveChangesAsync(cancellationToken) > 0;

                if (!result) return Result<Unit>.Failure("Failed to create activity");

                return Result<Unit>.Success(Unit.Value);
            }
        }
    }
}
