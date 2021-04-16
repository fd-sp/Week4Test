using AnagraficaClienti.EntitiesLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnagraficaClienti.ContextLayer.Configuration
{
    class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(k => k.Id);
            builder.HasOne(c => c.Client).WithMany(o => o.Orders);
            builder.Property(p => p.OrderDate).HasDefaultValue(DateTime.Now);
            builder.Property(p => p.OrderCode).IsRequired();
            builder.Property(p => p.ProductCode).IsRequired();
            builder.Property(p => p.Amount).IsRequired();
            builder.Property(p => p.ClientId).IsRequired();
        }
    }
}
