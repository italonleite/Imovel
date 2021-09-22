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
   public class ImmobileMapping : IEntityTypeConfiguration<Immobile>
    {
        
        public void Configure(EntityTypeBuilder<Immobile> builder)
        {
            builder.ToTable("Immobiles");
            builder.HasKey(i => i.ImmobileId);
            builder.Property(i => i.ImmobileType)
                .IsRequired()
                .HasColumnType("varchar(30)");
            builder.HasOne(i => i.Address).WithOne();              
                  


        }
    }
}
