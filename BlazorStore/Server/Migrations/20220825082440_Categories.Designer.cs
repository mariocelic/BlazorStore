﻿// <auto-generated />
using BlazorStore.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorStore.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220825082440_Categories")]
    partial class Categories
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorStore.Shared.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Beers",
                            Url = "beers"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Wine",
                            Url = "wines"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Soft Drinks",
                            Url = "soft-drinks"
                        });
                });

            modelBuilder.Entity("BlazorStore.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "A light, crisp and bitter IPA brewed with English and American hops. A small batch brewed only once.",
                            ImageUrl = "https://images.punkapi.com/v2/keg.png",
                            Price = 6.99m,
                            Title = "Buzz"
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "A titillating, neurotic, peroxide punk of a Pale Ale. Combining attitude, style, substance, and a little bit of low self esteem for good measure; what would your mother say? The seductive lure of the sassy passion fruit hop proves too much to resist. All that is even before we get onto the fact that there are no additives, preservatives, pasteurization or strings attached. All wrapped up with the customary BrewDog bite and imaginative twist.",
                            ImageUrl = "https://images.punkapi.com/v2/2.png",
                            Price = 7.99m,
                            Title = "Trashy Blonde"
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Japanese citrus fruit intensifies the sour nature of this German classic.",
                            ImageUrl = "https://images.punkapi.com/v2/4.png",
                            Price = 9.99m,
                            Title = "Berliner Weisse With Yuzu - B-Sides"
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "\"An Imperial Pilsner in collaboration with beer writers. Tradition. Homage. Revolution. We wanted to showcase the awesome backbone of the Czech brewing tradition, the noble Saaz hop, and also tip our hats to the modern beers that rock our world, and the people who make them.",
                            ImageUrl = "https://images.punkapi.com/v2/5.png",
                            Price = 9.99m,
                            Title = "Avery Brown Dredge"
                        });
                });

            modelBuilder.Entity("BlazorStore.Shared.Product", b =>
                {
                    b.HasOne("BlazorStore.Shared.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
