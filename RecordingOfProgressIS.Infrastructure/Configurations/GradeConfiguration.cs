using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecordingOfProgressIS.Domain.Models;

namespace RecordingOfProgressIS.Infrastructure.Configurations
{
    public class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> builder)
        {
            builder.HasKey(g => g.Id);

            builder.HasOne(g => g.Discipline)
                .WithMany(d => d.Grades);

            builder.HasOne(g => g.Student)
                .WithMany(s => s.Grades);

            builder.HasOne(g => g.Professor)
                .WithMany(p => p.Grades);
        }
    }
}
