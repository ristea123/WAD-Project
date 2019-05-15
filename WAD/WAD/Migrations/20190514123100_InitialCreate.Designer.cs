﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WAD.Models;

namespace WAD.Migrations
{
    [DbContext(typeof(SearchAppContext))]
    [Migration("20190514123100_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WAD.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("LoggedIn");

                    b.Property<string>("Password");

                    b.Property<string>("User");

                    b.HasKey("ClientId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("WAD.Models.Developer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("LoggedIn");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("User");

                    b.HasKey("ID");

                    b.ToTable("Developers");
                });

            modelBuilder.Entity("WAD.Models.Game", b =>
                {
                    b.Property<int>("GameId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClientId");

                    b.Property<int>("DeveloperId");

                    b.Property<string>("Name");

                    b.Property<int?>("ReviewerId");

                    b.Property<int>("ReviewrId");

                    b.Property<string>("Reviews");

                    b.HasKey("GameId");

                    b.HasIndex("ClientId");

                    b.HasIndex("DeveloperId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("WAD.Models.Reviewer", b =>
                {
                    b.Property<int>("ReviewerId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("LoggedIn");

                    b.Property<string>("Password");

                    b.Property<string>("User");

                    b.HasKey("ReviewerId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("WAD.Models.Game", b =>
                {
                    b.HasOne("WAD.Models.Client")
                        .WithMany("Favourites")
                        .HasForeignKey("ClientId");

                    b.HasOne("WAD.Models.Developer")
                        .WithMany("Games")
                        .HasForeignKey("DeveloperId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("WAD.Models.Reviewer")
                        .WithMany("ReviewedGames")
                        .HasForeignKey("ReviewerId");
                });
#pragma warning restore 612, 618
        }
    }
}
