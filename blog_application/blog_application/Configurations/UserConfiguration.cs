using blog_application.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace blog_application.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.FirstName)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.MiddleName)
                .HasColumnType("nvarchar")
                .HasMaxLength(50);

            builder.Property(x => x.LastName)
                .HasColumnType("nvarchar")
                .HasMaxLength(50);

            builder.Property(x => x.Email)
                .HasColumnType("nvarchar")
                .HasMaxLength(200)
                .IsRequired();

            builder.Property(x => x.ContactNumber)
                .HasColumnType("bigint")
                .IsRequired();

            builder.Property(x => x.Salary)
                .HasColumnType("decimal");
        }
    }
}
