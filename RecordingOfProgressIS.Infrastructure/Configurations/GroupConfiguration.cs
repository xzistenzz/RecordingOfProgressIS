using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RecordingOfProgressIS.Domain.Models;

namespace RecordingOfProgressIS.Infrastructure.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasKey(g => g.Id);

            builder.HasMany(g => g.Students)
                .WithOne(s => s.Group);

            builder.HasMany(g => g.Disciplines)
                .WithMany(d => d.Groups)
                .UsingEntity<DisciplineGroupProfessor>();
        }
    }
}
