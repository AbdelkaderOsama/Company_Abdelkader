﻿// <auto-generated />
using System;
using Company_Abdelkader.DAL.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Company_Abdelkader.DAL.Data.Migrations
{
    [DbContext(typeof(CompanyDbContext))]
    [Migration("20250317011843_EmployeeDepartmentRelashionShip")]
    partial class EmployeeDepartmentRelashionShip
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Company_Abdelkader.DAL.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 10L, 10);

                    b.Property<DateTime>("DateOfCreation")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("code")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Company_Abdelkader.DAL.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("HiringDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("ISActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<decimal>("salary")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Company_Abdelkader.DAL.Models.Employee", b =>
                {
                    b.HasOne("Company_Abdelkader.DAL.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Company_Abdelkader.DAL.Models.Department", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
