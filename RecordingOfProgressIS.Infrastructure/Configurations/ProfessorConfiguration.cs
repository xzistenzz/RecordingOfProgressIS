using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecordingOfProgressIS.Domain.Models;

namespace RecordingOfProgressIS.Infrastructure.Configurations
{
    public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasMany(p => p.Disciplines)
                .WithMany(d => d.Professors)
                .UsingEntity<DisciplineGroupProfessor>();
        }
    }
}
