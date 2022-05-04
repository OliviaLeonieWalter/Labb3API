﻿// <auto-generated />
using System;
using Labb3API.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Labb3API.API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220427094853_initDatabase")]
    partial class initDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Labb2API.Model.Hobby", b =>
                {
                    b.Property<int>("HobbyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HobbyDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HobbyTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HobbyId");

                    b.ToTable("Hobbies");

                    b.HasData(
                        new
                        {
                            HobbyId = 1,
                            HobbyDescription = "Floorball is a type of floor hockey with five players and a goalkeeper in each team.",
                            HobbyTitle = "Floorboll"
                        },
                        new
                        {
                            HobbyId = 2,
                            HobbyDescription = "Game Development is the art of creating games and describes the design, development and release of a game.",
                            HobbyTitle = "Game Development"
                        },
                        new
                        {
                            HobbyId = 3,
                            HobbyDescription = "Beekeeping (or apiculture) is the maintenance of bee colonies, commonly in man-made hives, by humans.",
                            HobbyTitle = "Beekeeping"
                        },
                        new
                        {
                            HobbyId = 4,
                            HobbyDescription = "Sleep is associated with a state of muscle relaxation and reduced perception of environmental stimuli.",
                            HobbyTitle = "Sleeping"
                        },
                        new
                        {
                            HobbyId = 5,
                            HobbyDescription = "Hiking is a long, vigorous walk, usually on trails or footpaths in the countryside.",
                            HobbyTitle = "Hiking"
                        });
                });

            modelBuilder.Entity("Labb2API.Model.JoinTableUserHobby", b =>
                {
                    b.Property<int>("JoinId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HobbyId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("JoinId");

                    b.HasIndex("HobbyId");

                    b.HasIndex("UserId");

                    b.ToTable("JoinHobbyUser");

                    b.HasData(
                        new
                        {
                            JoinId = 1,
                            HobbyId = 1,
                            UserId = 1
                        },
                        new
                        {
                            JoinId = 2,
                            HobbyId = 1,
                            UserId = 4
                        },
                        new
                        {
                            JoinId = 3,
                            HobbyId = 2,
                            UserId = 3
                        },
                        new
                        {
                            JoinId = 4,
                            HobbyId = 3,
                            UserId = 2
                        },
                        new
                        {
                            JoinId = 5,
                            HobbyId = 4,
                            UserId = 5
                        },
                        new
                        {
                            JoinId = 6,
                            HobbyId = 5,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Labb2API.Model.Link", b =>
                {
                    b.Property<int>("LinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HobbyId")
                        .HasColumnType("int");

                    b.Property<string>("LinkDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LinkId");

                    b.HasIndex("HobbyId");

                    b.HasIndex("UserId");

                    b.ToTable("Links");

                    b.HasData(
                        new
                        {
                            LinkId = 1,
                            HobbyId = 1,
                            LinkDescription = "A Webside to the national swedish floorball commitee",
                            LinkUrl = "https://www.innebandy.se/",
                            UserId = 4
                        },
                        new
                        {
                            LinkId = 2,
                            HobbyId = 1,
                            LinkDescription = "A Webside with all new about swedish floorball",
                            LinkUrl = "https://innebandymagazinet.se/",
                            UserId = 1
                        },
                        new
                        {
                            LinkId = 3,
                            HobbyId = 4,
                            LinkDescription = "A Link to a Youtube-video with 10 music for deep sleep",
                            LinkUrl = "https://www.youtube.com/watch?v=rulvcTfez5w",
                            UserId = 5
                        },
                        new
                        {
                            LinkId = 4,
                            HobbyId = 5,
                            LinkDescription = "A Webside for the best hiking trails in Sweden",
                            LinkUrl = "https://visitsweden.com/what-to-do/nature-outdoors/hiking/top-hiking-routes-sweden/",
                            UserId = 1
                        },
                        new
                        {
                            LinkId = 5,
                            HobbyId = 2,
                            LinkDescription = "A Website for all the latest news in game development",
                            LinkUrl = "https://www.gamedeveloper.com/",
                            UserId = 3
                        },
                        new
                        {
                            LinkId = 6,
                            HobbyId = 3,
                            LinkDescription = "A Webside with tips and tricks for beekeeping beginners",
                            LinkUrl = "https://beebuilt.com/pages/beekeeping-for-beginners",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("Labb2API.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Age")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Age = new DateTime(1992, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Klara.Berg@Email.com",
                            FirstName = "Klara",
                            LastName = "Berg",
                            Phone = "0731509837"
                        },
                        new
                        {
                            UserId = 2,
                            Age = new DateTime(2013, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "NallePuh@Honung.com",
                            FirstName = "Nalle",
                            LastName = "Puh",
                            Phone = "0731121122"
                        },
                        new
                        {
                            UserId = 3,
                            Age = new DateTime(1997, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Olivia.Walter@Email.com",
                            FirstName = "Olivia",
                            LastName = "Walter",
                            Phone = "0731502323"
                        },
                        new
                        {
                            UserId = 4,
                            Age = new DateTime(1996, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Joakim.Bjorklund@Email.com",
                            FirstName = "Joakim",
                            LastName = "Björklund",
                            Phone = "0708893321"
                        },
                        new
                        {
                            UserId = 5,
                            Age = new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Zelda.Pyttepatte@Miaumail.com",
                            FirstName = "Zelda",
                            LastName = "Pyttepatte",
                            Phone = "0703332221"
                        });
                });

            modelBuilder.Entity("Labb2API.Model.JoinTableUserHobby", b =>
                {
                    b.HasOne("Labb2API.Model.Hobby", "Hobby")
                        .WithMany("JoinTableUserHobbies")
                        .HasForeignKey("HobbyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb2API.Model.User", "user")
                        .WithMany("JoinTableUserHobbies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Labb2API.Model.Link", b =>
                {
                    b.HasOne("Labb2API.Model.Hobby", "Hobby")
                        .WithMany("Links")
                        .HasForeignKey("HobbyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb2API.Model.User", "User")
                        .WithMany("links")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
