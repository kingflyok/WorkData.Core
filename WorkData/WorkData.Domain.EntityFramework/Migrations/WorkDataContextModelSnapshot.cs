﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WorkData.Domain.EntityFramework.EntityFramework.Contexts;

namespace WorkData.Domain.EntityFramework.Migrations
{
    [DbContext(typeof(WorkDataContext))]
    partial class WorkDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("WorkData.Domain.Permissions.Roles.BaseRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasMaxLength(128);

                    b.Property<string>("BelongUserId")
                        .HasColumnName("BelongUserId")
                        .HasMaxLength(200);

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnName("Code")
                        .HasMaxLength(20);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("CreateTime");

                    b.Property<string>("CreateUserId")
                        .HasColumnName("CreateUserId")
                        .HasMaxLength(200);

                    b.Property<bool>("IsDelete")
                        .HasColumnName("IsDelete");

                    b.Property<string>("MemberUserId")
                        .HasColumnName("MemberUserId")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("ModifierTime")
                        .HasColumnName("ModifierTime");

                    b.Property<string>("ModifierUserId")
                        .HasColumnName("ModifierUserId")
                        .HasMaxLength(200);

                    b.Property<string>("RoleName")
                        .HasColumnName("RoleName")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("BaseRole");
                });

            modelBuilder.Entity("WorkData.Domain.Permissions.UserRoles.UserRole", b =>
                {
                    b.Property<string>("BaseRoleId")
                        .HasColumnName("BaseRoleId")
                        .HasMaxLength(128);

                    b.Property<string>("BaseUserId")
                        .HasColumnName("BaseUserId")
                        .HasMaxLength(128);

                    b.HasKey("BaseRoleId", "BaseUserId");

                    b.HasIndex("BaseUserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("WorkData.Domain.Permissions.Users.BaseUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasMaxLength(128);

                    b.Property<string>("BelongUserId")
                        .HasColumnName("BelongUserId")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("CreateTime");

                    b.Property<string>("CreateUserId")
                        .HasColumnName("CreateUserId")
                        .HasMaxLength(200);

                    b.Property<bool>("IsDelete")
                        .HasColumnName("IsDelete");

                    b.Property<string>("MemberUserId")
                        .HasColumnName("MemberUserId")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("ModifierTime")
                        .HasColumnName("ModifierTime");

                    b.Property<string>("ModifierUserId")
                        .HasColumnName("ModifierUserId")
                        .HasMaxLength(200);

                    b.Property<string>("Password");

                    b.Property<string>("Salt");

                    b.Property<string>("UserName")
                        .HasColumnName("UserName")
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("BaseUser");
                });

            modelBuilder.Entity("WorkData.Domain.Permissions.Users.BaseUserMember", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasMaxLength(128);

                    b.Property<string>("BaseUserId")
                        .IsRequired()
                        .HasColumnName("BaseUserId")
                        .HasMaxLength(128);

                    b.Property<string>("BelongUserId")
                        .HasColumnName("BelongUserId")
                        .HasMaxLength(200);

                    b.Property<DateTime>("CreateTime")
                        .HasColumnName("CreateTime");

                    b.Property<string>("CreateUserId")
                        .HasColumnName("CreateUserId")
                        .HasMaxLength(200);

                    b.Property<bool>("IsDelete")
                        .HasColumnName("IsDelete");

                    b.Property<string>("MemberUserId")
                        .HasColumnName("MemberUserId")
                        .HasMaxLength(200);

                    b.Property<DateTime?>("ModifierTime")
                        .HasColumnName("ModifierTime");

                    b.Property<string>("ModifierUserId")
                        .HasColumnName("ModifierUserId")
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("BaseUserId");

                    b.ToTable("BaseUserMember");
                });

            modelBuilder.Entity("WorkData.Domain.Permissions.UserRoles.UserRole", b =>
                {
                    b.HasOne("WorkData.Domain.Permissions.Roles.BaseRole", "BaseRole")
                        .WithMany("UserRoles")
                        .HasForeignKey("BaseRoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WorkData.Domain.Permissions.Users.BaseUser", "BaseUser")
                        .WithMany("UserRoles")
                        .HasForeignKey("BaseUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WorkData.Domain.Permissions.Users.BaseUserMember", b =>
                {
                    b.HasOne("WorkData.Domain.Permissions.Users.BaseUser", "BaseUser")
                        .WithMany("BaseUserClaims")
                        .HasForeignKey("BaseUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
