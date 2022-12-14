﻿// <auto-generated />
using GenerateCifApi.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GenerateCifApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GenerateCifApi.Models.CifUser", b =>
                {
                    b.Property<int>("CifId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CifId"), 1L, 1);

                    b.Property<string>("emailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CifId");

                    b.ToTable("CifUser");

                    b.HasData(
                        new
                        {
                            CifId = 1,
                            emailId = "aaa@test.com"
                        },
                        new
                        {
                            CifId = 2,
                            emailId = "bbb@test.com"
                        },
                        new
                        {
                            CifId = 3,
                            emailId = "ccc@test.com"
                        },
                        new
                        {
                            CifId = 4,
                            emailId = "ddd@test.com"
                        },
                        new
                        {
                            CifId = 5,
                            emailId = "eee@test.com"
                        },
                        new
                        {
                            CifId = 6,
                            emailId = "fff@test.com"
                        },
                        new
                        {
                            CifId = 7,
                            emailId = "ggg@test.com"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
