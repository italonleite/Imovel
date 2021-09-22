using Imovel.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imovel.Data.Mappings
{
   public class AddressMapping : IEntityTypeConfiguration<Address>
    {
        
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(a => a.AddressId);
            builder.Property(a => a.zip)
                .IsRequired()
                .HasColumnType("varchar(8)");
            builder.Property(a => a.street)
                .IsRequired()
                .HasColumnType("varchar(200)");
            builder.Property(a => a.number).HasColumnType("varchar(5)");
            builder.Property(a => a.complement).HasColumnType("varchar(50)");
            builder.Property(a => a.district).HasColumnType("varchar(50)");
            builder.Property(a => a.city).HasColumnType("varchar(50)");            
            builder.Property(a => a.state).HasColumnType("varchar(2)");
            builder.ToTable("Adresses");
        }
    }
}
