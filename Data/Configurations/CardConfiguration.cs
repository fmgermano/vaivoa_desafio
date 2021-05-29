using vvef.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace vvef.Data.Configurations
{
    public class CardConfiguration : IEntityTypeConfiguration<Card>
    {
        public void Configure(EntityTypeBuilder<Card> builder)
        {
            builder
                .HasKey(m => m.Id);

                
            builder
                .Property(m => m.Id)
                .IsRequired()
                .HasMaxLength(16);

            builder
                .HasOne(m => m.Cliente)
                .WithMany(a => a.Cards)
                .HasForeignKey(m => m.ClienteId);
                
            builder
                .HasOne(m => m.Cliente)
                .WithMany(a => a.Cards)
                .HasForeignKey(m => m.Cliente.Email);

            builder
                .ToTable("Clients");
        }
    }
}