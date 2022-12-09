﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ekz2.ViewModel;

namespace ekz2.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ekz2.Models.Customer4", b =>
                {
                    b.Property<int>("cnum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("comm")
                        .HasColumnType("int");

                    b.Property<string>("sname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cnum");

                    b.ToTable("Customerrr");
                });

            modelBuilder.Entity("ekz2.Models.Diagnosis", b =>
                {
                    b.Property<int>("dnum")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("comm")
                        .HasColumnType("int");

                    b.Property<string>("sname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("dnum");

                    b.ToTable("Diagnosisss");
                });
#pragma warning restore 612, 618
        }
    }
}