using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using paytr.Domain.Entities;
using paytr.Domain.Enums;

namespace paytr.Persistence.EntityFramework.Configrations
{
    public sealed class OrderHistoryConfigration : IEntityTypeConfiguration<OrderHistory>
    {
        public void Configure(EntityTypeBuilder<OrderHistory> builder)
        {
            // ID Primary Key
            builder.HasKey(oh => oh.Id);

            // OrderStatus Enum
            builder.Property(oh => oh.Status)
                .HasConversion<int>()
                .IsRequired()
                .HasDefaultValue(OrderStatus.Pending)
                .HasColumnType("tinyint");


            // Description
            builder.Property(oh => oh.Description)
                .HasMaxLength(2500)
                .IsRequired(false);

            // Common Properties
            builder.Property(e => e.CreatedAt)
                .IsRequired()
                .HasDefaultValue(DateTimeOffset.UtcNow);

            builder.Property(e => e.UpdatedAt)
                .IsRequired(false);

            // //Relationships
            // builder.HasOne(oh => oh.Order)
            //     .WithMany(o => o.Histories)
            //     .HasForeignKey(oh => oh.OrderId);

            builder.ToTable("order_histories");
        }
    }
}

