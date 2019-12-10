﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cedal_backend.Data;

namespace cedal_backend.Migrations
{
    [DbContext(typeof(CedalContext))]
    [Migration("20191210122153_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cedal_backend.Models.Address", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("PostalCode");

                    b.Property<string>("Province");

                    b.Property<string>("Street");

                    b.HasKey("ID");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("cedal_backend.Models.Education", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicantID");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<int>("EducationType");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("ApplicantID");

                    b.ToTable("Educations");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Education");
                });

            modelBuilder.Entity("cedal_backend.Models.Event", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressID");

                    b.Property<DateTime>("DateTime");

                    b.Property<string>("Description");

                    b.Property<string>("EventImage");

                    b.Property<int>("EventTypes");

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.HasIndex("AddressID");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("cedal_backend.Models.Module", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("cedal_backend.Models.User", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContactNumber");

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email");

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.Property<int>("UserType");

                    b.HasKey("ID");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("cedal_backend.Models.Tertiary", b =>
                {
                    b.HasBaseType("cedal_backend.Models.Education");

                    b.Property<string>("Major");

                    b.HasDiscriminator().HasValue("Tertiary");
                });

            modelBuilder.Entity("cedal_backend.Models.Applicant", b =>
                {
                    b.HasBaseType("cedal_backend.Models.User");

                    b.HasDiscriminator().HasValue("Applicant");
                });

            modelBuilder.Entity("cedal_backend.Models.Education", b =>
                {
                    b.HasOne("cedal_backend.Models.Applicant")
                        .WithMany("Education")
                        .HasForeignKey("ApplicantID");
                });

            modelBuilder.Entity("cedal_backend.Models.Event", b =>
                {
                    b.HasOne("cedal_backend.Models.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressID");
                });
#pragma warning restore 612, 618
        }
    }
}