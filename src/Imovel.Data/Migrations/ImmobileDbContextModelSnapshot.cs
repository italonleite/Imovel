﻿// <auto-generated />
using System;
using Imovel.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Imovel.Data.Migrations
{
    [DbContext(typeof(ImmobileDbContext))]
    partial class ImmobileDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Imovel.Domain.Models.Address", b =>
                {
                    b.Property<Guid>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("city")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("complement")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("district")
                        .HasColumnType("varchar(50)");

                    b.Property<string>("number")
                        .HasColumnType("varchar(5)");

                    b.Property<string>("state")
                        .HasColumnType("varchar(2)");

                    b.Property<string>("street")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.Property<string>("zip")
                        .IsRequired()
                        .HasColumnType("varchar(8)");

                    b.HasKey("AddressId");

                    b.ToTable("Adresses");
                });

            modelBuilder.Entity("Imovel.Domain.Models.Immobile", b =>
                {
                    b.Property<Guid>("ImmobileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AddressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImmobileType")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.HasKey("ImmobileId");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Immobiles");
                });

            modelBuilder.Entity("Imovel.Domain.Models.Immobile", b =>
                {
                    b.HasOne("Imovel.Domain.Models.Address", "Address")
                        .WithOne()
                        .HasForeignKey("Imovel.Domain.Models.Immobile", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });
#pragma warning restore 612, 618
        }
    }
}
