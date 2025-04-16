using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecordingOfProgressIS.Domain;

namespace RecordingOfProgressIS.Infrastructure.Configurations
{
    public class AcademicDisciplineConfiguration : IEntityTypeConfiguration<AcademicDiscipline>
    {
        public void Configure(EntityTypeBuilder<AcademicDiscipline> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(d => d.Groups)
                .WithMany(g => g.Disciplines)
                .UsingEntity<DisciplineGroupProfessor>();
        }
    }
}
