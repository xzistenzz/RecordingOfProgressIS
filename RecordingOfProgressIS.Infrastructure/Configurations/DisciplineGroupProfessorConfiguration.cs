using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecordingOfProgressIS.Domain.Models;

namespace RecordingOfProgressIS.Infrastructure.Configurations
{
    public class DisciplineGroupProfessorConfiguration : IEntityTypeConfiguration<DisciplineGroupProfessor>
    {
        public void Configure(EntityTypeBuilder<DisciplineGroupProfessor> builder)
        {
            builder.HasOne(d => d.Discipline)
                .WithMany(d => d.DisciplineGroupProfessors)
                .HasForeignKey(x => x.DisciplineId);

            builder.HasOne(d => d.Group)
                .WithMany(g => g.DisciplineGroupProfessors)
                .HasForeignKey(x => x.GroupId);

            builder.HasOne(d => d.Professor)
                .WithMany(p => p.DisciplineGroupProfessors)
                .HasForeignKey(x => x.ProfessorId);
        }
    }
}
