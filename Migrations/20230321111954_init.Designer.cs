﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop.Data;

namespace Shop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230321111954_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Shop.Models.Game", b =>
                {
                    b.Property<Guid>("GameId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("GamePictureURL");

                    b.Property<string>("GameTitle");

                    b.Property<int>("Genre");

                    b.Property<float>("Price");

                    b.HasKey("GameId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Shop.Models.Games_Person", b =>
                {
                    b.Property<Guid>("GameId");

                    b.Property<Guid>("PersonId");

                    b.HasKey("GameId", "PersonId");

                    b.HasIndex("PersonId");

                    b.ToTable("Games_Persons");
                });

            modelBuilder.Entity("Shop.Models.Person", b =>
                {
                    b.Property<Guid>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Firstname");

                    b.Property<string>("Lastname");

                    b.Property<string>("UserEmail");

                    b.Property<string>("UserPassword");

                    b.HasKey("PersonId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("Shop.Models.Games_Person", b =>
                {
                    b.HasOne("Shop.Models.Game", "Games")
                        .WithMany("OwnedGames")
                        .HasForeignKey("GameId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Shop.Models.Person", "Persons")
                        .WithMany("OwnedGames")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
