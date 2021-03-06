// <auto-generated />
using System;
using LektionVinuylCollection.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LektionVinuylCollection.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20211213082438_Added_ArtstID_ListVinylvariables")]
    partial class Added_ArtstID_ListVinylvariables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("LektionVinuylCollection.Entities.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Created")
                        .HasColumnType("int");

                    b.Property<string>("FavoriteCar")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Artists");
                });

            modelBuilder.Entity("LektionVinuylCollection.Entities.Vinyl", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Artist")
                        .HasColumnType("longtext");

                    b.Property<int>("ArtistID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ArtistID");

                    b.ToTable("Vinyls");
                });

            modelBuilder.Entity("LektionVinuylCollection.Entities.Vinyl", b =>
                {
                    b.HasOne("LektionVinuylCollection.Entities.Artist", null)
                        .WithMany("Vinyls")
                        .HasForeignKey("ArtistID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LektionVinuylCollection.Entities.Artist", b =>
                {
                    b.Navigation("Vinyls");
                });
#pragma warning restore 612, 618
        }
    }
}
