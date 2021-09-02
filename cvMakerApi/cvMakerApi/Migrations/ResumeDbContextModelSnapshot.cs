﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cvMakerApi.Models;

namespace cvMakerApi.Migrations
{
    [DbContext(typeof(ResumeDbContext))]
    partial class ResumeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cvMakerApi.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("country")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("CountryId");

                    b.ToTable("countries");
                });

            modelBuilder.Entity("cvMakerApi.Models.ResumeMaker", b =>
                {
                    b.Property<int>("ResumeMakerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("SocialorsiteA")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SocialorsiteB")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("SocialorsiteC")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("about")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("educationorcrouseA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("educationorcrouseB")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("educationorcrouseC")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("educationorcrouseD")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("picture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("servicesA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("servicesB")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ResumeMakerId");

                    b.HasIndex("CountryId");

                    b.ToTable("resumeMakers");
                });

            modelBuilder.Entity("cvMakerApi.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("cvMakerApi.Models.ResumeMaker", b =>
                {
                    b.HasOne("cvMakerApi.Models.Country", "country")
                        .WithMany("resumeMakers")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("country");
                });

            modelBuilder.Entity("cvMakerApi.Models.Country", b =>
                {
                    b.Navigation("resumeMakers");
                });
#pragma warning restore 612, 618
        }
    }
}