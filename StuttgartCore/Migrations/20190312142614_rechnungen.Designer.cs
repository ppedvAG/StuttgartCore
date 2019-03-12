﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StuttgartCore.Models;

namespace StuttgartCore.Migrations
{
    [DbContext(typeof(RechnungContext))]
    [Migration("20190312142614_rechnungen")]
    partial class rechnungen
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StuttgartCore.Models.Positionen", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Anzahl");

                    b.Property<float>("Preis");

                    b.Property<int>("RechnungenID");

                    b.HasKey("ID");

                    b.HasIndex("RechnungenID");

                    b.ToTable("Positionens");
                });

            modelBuilder.Entity("StuttgartCore.Models.Rechnungen", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum");

                    b.Property<string>("KopfText");

                    b.Property<int>("KundenID");

                    b.Property<float>("Summe");

                    b.HasKey("ID");

                    b.ToTable("Rechnungens");
                });

            modelBuilder.Entity("StuttgartCore.Models.Positionen", b =>
                {
                    b.HasOne("StuttgartCore.Models.Rechnungen")
                        .WithMany("Positionen")
                        .HasForeignKey("RechnungenID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
