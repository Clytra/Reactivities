using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Application.Common.Interfaces
{
    public interface IDataContext
    {
        DbSet<Activity> Activities { get; }
        DbSet<ActivityAttendee> ActivityAttendees { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
