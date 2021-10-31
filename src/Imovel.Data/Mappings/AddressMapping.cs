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
            builder.Property(a => a.Zip)
                .IsRequired()
                .HasColumnType("varchar(8)");
            builder.Property(a => a.Street)
                .IsRequired()
                .HasColumnType("varchar(200)");
            builder.Property(a => a.Number).HasColumnType("varchar(10)");
            builder.Property(a => a.Complement).HasColumnType("varchar(50)");
            builder.Property(a => a.District).HasColumnType("varchar(50)");
            builder.Property(a => a.City).HasColumnType("varchar(50)");            
            builder.Property(a => a.State).HasColumnType("varchar(2)");            
            builder.ToTable("Address");
        }
    }
}
