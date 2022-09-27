using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Configurations
{
    internal class ActivityConfiguration : IEntityTypeConfiguration<Activity>
    {
        public void Configure(EntityTypeBuilder<Activity> builder)
        {
            builder.HasKey(key => key.Id);

            builder.Property(prop => prop.Title).HasMaxLength(25);
            builder.Property(prop => prop.Description).HasMaxLength(250);
            builder.Property(prop => prop.City).HasMaxLength(15);
        }
    }
}
