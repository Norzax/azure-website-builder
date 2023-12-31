﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistance;

#nullable disable

namespace Persistance.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DataAccess.Entities.AccessLevel", b =>
                {
                    b.Property<int>("AccessLevelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccessLevelID"), 1L, 1);

                    b.Property<string>("Description")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("AccessLevelID");

                    b.ToTable("accessLevels");

                    b.HasData(
                        new
                        {
                            AccessLevelID = 1,
                            Description = "AllControll"
                        },
                        new
                        {
                            AccessLevelID = 2,
                            Description = "Review"
                        },
                        new
                        {
                            AccessLevelID = 3,
                            Description = "Changable"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.DesignHistory", b =>
                {
                    b.Property<int>("DesignHistoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DesignHistoryID"), 1L, 1);

                    b.Property<int>("DesignID")
                        .HasColumnType("int");

                    b.Property<string>("ModifiedAt")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ModifiedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Version")
                        .HasColumnType("int");

                    b.HasKey("DesignHistoryID");

                    b.ToTable("designHistories");

                    b.HasData(
                        new
                        {
                            DesignHistoryID = 1,
                            DesignID = 1,
                            ModifiedAt = "2023-10-17",
                            ModifiedBy = "User1",
                            Version = 1
                        },
                        new
                        {
                            DesignHistoryID = 2,
                            DesignID = 2,
                            ModifiedAt = "2023-10-18",
                            ModifiedBy = "User2",
                            Version = 1
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProjectId"), 1L, 1);

                    b.Property<string>("CreatedAt")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("ProjectDescription")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ProjectName")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UpdateAt")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ProjectId");

                    b.ToTable("projects");

                    b.HasData(
                        new
                        {
                            ProjectId = 1,
                            CreatedAt = "2023-10-17",
                            ProjectDescription = "Description 1",
                            ProjectName = "Project 1",
                            UpdateAt = "2023-10-18"
                        },
                        new
                        {
                            ProjectId = 2,
                            CreatedAt = "2023-10-18",
                            ProjectDescription = "Description 2",
                            ProjectName = "Project 2",
                            UpdateAt = "2023-10-19"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.PublishedDesign", b =>
                {
                    b.Property<int>("PublishedDesignID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PublishedDesignID"), 1L, 1);

                    b.Property<DateTime>("PublishDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PublishedBy")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PublishedDesignID");

                    b.ToTable("publisedDesigns");

                    b.HasData(
                        new
                        {
                            PublishedDesignID = 1,
                            PublishDate = new DateTime(2023, 10, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublishedBy = "Admin1"
                        },
                        new
                        {
                            PublishedDesignID = 2,
                            PublishDate = new DateTime(2023, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            PublishedBy = "Admin2"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserID"), 1L, 1);

                    b.Property<string>("Email")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Username")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UserID");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            UserID = 1,
                            Email = "user1@example.com",
                            Password = "password1",
                            Username = "user1"
                        },
                        new
                        {
                            UserID = 2,
                            Email = "user2@example.com",
                            Password = "password2",
                            Username = "user2"
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.UserProjectAccess", b =>
                {
                    b.Property<int>("UserProjectAccessID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserProjectAccessID"), 1L, 1);

                    b.Property<int>("AccessLevelID")
                        .HasColumnType("int");

                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("UserProjectAccessID");

                    b.HasIndex("AccessLevelID");

                    b.HasIndex("ProjectID");

                    b.HasIndex("UserID");

                    b.ToTable("userProjectAccesses");

                    b.HasData(
                        new
                        {
                            UserProjectAccessID = 1,
                            AccessLevelID = 1,
                            ProjectID = 1,
                            UserID = 1
                        },
                        new
                        {
                            UserProjectAccessID = 2,
                            AccessLevelID = 2,
                            ProjectID = 2,
                            UserID = 2
                        });
                });

            modelBuilder.Entity("DataAccess.Entities.UserProjectAccess", b =>
                {
                    b.HasOne("DataAccess.Entities.AccessLevel", "AccessLevel")
                        .WithMany()
                        .HasForeignKey("AccessLevelID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataAccess.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccessLevel");

                    b.Navigation("Project");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
