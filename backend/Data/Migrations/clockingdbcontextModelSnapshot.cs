﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace clockingapi.Data.Migrations
{
    [DbContext(typeof(clockingdbcontext))]
    partial class clockingdbcontextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Clocking", b =>
                {
                    b.Property<string>("PersonalFileNumber")
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

                    b.HasKey("PersonalFileNumber");

                    b.ToTable("Clockings");
                });

            modelBuilder.Entity("Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"), 1L, 1);

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

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

            modelBuilder.Entity("Time", b =>
                {
                    b.Property<int>("TimeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TimeId"), 1L, 1);

                    b.Property<DateTime>("ClockInTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ClockOutTime")
                        .HasColumnType("datetime2");

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

                    b.HasKey("TimeId");

                    b.ToTable("TimeDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
