using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Mapping
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Cpf)
            .IsRequired()
            .HasColumnName("Cpf");

            builder.Property(x => x.BirthDate)
            .IsRequired()
            .HasColumnName("BirthDate");

            builder.Property(c => c.Name)
            .IsRequired()
            .HasColumnName("Name");
        }
    }
}