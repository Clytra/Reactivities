using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    internal class ActivityAttendeeConfiguration : IEntityTypeConfiguration<ActivityAttendee>
    {
        public void Configure(EntityTypeBuilder<ActivityAttendee> builder)
        {
            builder.HasKey(key => new { key.AppUserId, key.ActivityId });

            builder.HasOne(user => user.AppUser)
                .WithMany(activities => activities.Activities)
                .HasForeignKey(key => key.AppUserId);

            builder.HasOne(activity => activity.Activity)
                .WithMany(attendees => attendees.Attendees)
                .HasForeignKey(key => key.ActivityId);
        }
    }
}
