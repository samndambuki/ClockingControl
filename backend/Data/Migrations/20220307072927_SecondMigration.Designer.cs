﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace clockingapi.Data.Migrations
{
    [DbContext(typeof(clockingdbcontext))]
    [Migration("20220307072927_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StaffId"), 1L, 1);

                    b.Property<string>("Active")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Department")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DepartmentId")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Designation")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PersonalFileNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Registered")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("StaffId");

                    b.ToTable("Staffs");

                    b.HasData(
                        new
                        {
                            StaffId = 1,
                            Active = "Yes/No",
                            Department = "The Staff's 1 Department is ",
                            DepartmentId = "The Staff's 1 DepartmentId is ",
                            Designation = "The Staff's 1 Role is ",
                            FirstName = "The Staff's 1 FirstName is ",
                            LastName = "The Staff's 1 LastName is  ",
                            PersonalFileNumber = "The Staff's 1 PersonalFileNumber is ",
                            Registered = "Yes/No"
                        },
                        new
                        {
                            StaffId = 2,
                            Active = "Yes/No",
                            Department = "The Staff's 2 Department is ",
                            DepartmentId = "The Staff's 2 DepartmentId is ",
                            Designation = "The Staff's 2 Role is ",
                            FirstName = "The Staff's 2 FirstName is ",
                            LastName = "The Staff's 2 LastName is  ",
                            PersonalFileNumber = "The Staff's 2 PersonalFileNumber is ",
                            Registered = "Yes/No"
                        },
                        new
                        {
                            StaffId = 3,
                            Active = "Yes/No",
                            Department = "The Staff's 3 Department is ",
                            DepartmentId = "The Staff's 3 DepartmentId is ",
                            Designation = "The Staff's 3 Role is ",
                            FirstName = "The Staff's 3 FirstName is ",
                            LastName = "The Staff's 3 LastName is  ",
                            PersonalFileNumber = "The Staff's 3 PersonalFileNumber is ",
                            Registered = "Yes/No"
                        },
                        new
                        {
                            StaffId = 4,
                            Active = "Yes/No",
                            Department = "The Staff's 4 Department is ",
                            DepartmentId = "The Staff's 4 DepartmentId is ",
                            Designation = "The Staff's 4 Role is ",
                            FirstName = "The Staff's 4 FirstName is ",
                            LastName = "The Staff's 4 LastName is  ",
                            PersonalFileNumber = "The Staff's 4 PersonalFileNumber is ",
                            Registered = "Yes/No"
                        },
                        new
                        {
                            StaffId = 5,
                            Active = "Yes/No",
                            Department = "The Staff's 5 Department is ",
                            DepartmentId = "The Staff's 5 DepartmentId is ",
                            Designation = "The Staff's 5 Role is ",
                            FirstName = "The Staff's 5 FirstName is ",
                            LastName = "The Staff's 5 LastName is  ",
                            PersonalFileNumber = "The Staff's 5 PersonalFileNumber is ",
                            Registered = "Yes/No"
                        },
                        new
                        {
                            StaffId = 6,
                            Active = "Yes/No",
                            Department = "The Staff's 6 Department is ",
                            DepartmentId = "The Staff's 6 DepartmentId is ",
                            Designation = "The Staff's 6 Role is ",
                            FirstName = "The Staff's 6 FirstName is ",
                            LastName = "The Staff's 6 LastName is  ",
                            PersonalFileNumber = "The Staff's 6 PersonalFileNumber is ",
                            Registered = "Yes/No"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
