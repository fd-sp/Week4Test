using AnagraficaClienti.EntitiesLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnagraficaClienti.ContextLayer.Configuration
{
    class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(k => k.Id);
            builder.HasMany(o => o.Orders).WithOne(c => c.Client);
            builder.Property(p => p.ClientCode).IsRequired();
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Surname).IsRequired();
        }
    }
}
