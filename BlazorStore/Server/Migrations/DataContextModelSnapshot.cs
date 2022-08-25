﻿// <auto-generated />
using BlazorStore.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorStore.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Re-brewed as a spring seasonal, this beer – which appeared originally as an Equity Punk shareholder creation – retains its trademark spicy, fruity edge. A perfect blend of Belgian Saison and US IPA, crushed peppercorns and heather honey are also added to produce a genuinely unique beer.",
                            ImageUrl = "https://images.punkapi.com/v2/6.png",
                            Price = 11.99m,
                            Title = "Electric India"
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 2,
                            Description = "This wine has a delicate bead, with a lovely persistent and creamy mousse. Nuances of stone fruit and melon on the nose are complemented by aromas of fresh cut apple, citrus and bread dough. The wine's linear and crisp acidity is perfectly balanced with the dosage to give the wine a harmonious fullness and length.\r\n\r\nBrut NV is by Stonyfell. It has a critic score of 91 out of 100 based on an aggregation of ratings from our partner sites.",
                            ImageUrl = "https://slash2.winevybe.com/wp-content/uploads/Stonyfell-Brut-NV.png",
                            Price = 29.99m,
                            Title = "Stonyfell Brut NV"
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 2,
                            Description = "Although best known for its world-class white wines, this delicious Rouleau red wine should not be missed. The fruits are cleaned from the fruits and vinified in wood for 12-15 months. Classic Auxey-Duresses wine: aromatic, brilliant, filled with notes of crunchy red fruits, cranberries and eret spices.\r\n\r\nAlthough best known for its world-class white wines, this delicious Rouleau red wine should not be missed. The fruits are cleaned from the fruits and vinified in wood for 12-15 months. Classic Auxey-Duresses wine: aromatic, brilliant, filled with notes of crunchy red fruits, cranberries and eret spices.\r\n\r\nAuxey-Duresses 1er Cru Rouge 2017 is a red wine produced in Burgundy, France by Domaine Roulot. It has a critic score of 77 out of 100 based on an aggregation of ratings from our partner sites. This 2017 vintage is available in 750ml volume.",
                            ImageUrl = "https://slash1.winevybe.com/wp-content/uploads/Domaine-Roulot-Auxey-Duresses-1er-Cru-Rouge-2017.png",
                            Price = 24.99m,
                            Title = "Domaine Roulot Auxey-Duresses 1er Cru Rouge 2017"
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 2,
                            Description = "Bright lifted aromas of dark plums with spice and liquorice notes. Dark red fruited, layers of plum and blackcurrant flavours, subtle oak and gentle tannins give depth and length on the palate. Matured in oak for 12 - 18 months.\r\n\r\nGR18 Langhorne Creek Shiraz is by Cleanskin. It has a critic score of 95 out of 100 based on an aggregation of ratings from our partner sites.",
                            ImageUrl = "https://slash1.winevybe.com/wp-content/uploads/Cleanskin-GR18-Langhorne-Creek-Shiraz.png",
                            Price = 22.99m,
                            Title = "Cleanskin GR18 Langhorne Creek Shiraz"
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 2,
                            Description = "One of the most ideal, aromatic Marlborough Sauvignon Blanc that will accompany brilliantly with seafood dishes. Wonderfully crisp and fragrant with an abundance of rich tropical fruit aromas, Lobster Reef is best enjoyed chilled and shared with family and friends. Now available in a convenient 187mL bottle.\r\n\r\nSauvignon Blanc 187mL is by Lobster Reef. It has a critic score of 64 out of 100 based on an aggregation of ratings from our partner sites.",
                            ImageUrl = "https://slash4.winevybe.com/wp-content/uploads/Lobster-Reef-Sauvignon-Blanc-187mL.png",
                            Price = 19.99m,
                            Title = "Lobster Reef Sauvignon Blanc"
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "Ingredients: water, honey 10%, herbs 0,9% (maté, guarana, ginger, ginko, ginseng and more), himalayan salt, carbon dioxide, acidity regulator: citric acid, antioxidant: vitamin C.",
                            ImageUrl = "https://images.punkapi.com/v2/7.png",
                            Price = 1.99m,
                            Title = "Mellos Natural energy 330ml"
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "Ingredients: water, honey 10%, herbs 0,7% (rose, hibiscus and more), carbon dioxide, acidity regulator: citric acid, antioxidant: vitamin C.",
                            ImageUrl = "https://images.punkapi.com/v2/8.png",
                            Price = 2.99m,
                            Title = "Mellos Ruža - 330ml"
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 3,
                            Description = "Ingredients: water, honey 10%, herbs 0,7% (mint, thyme and more), carbon dioxide, acidity regulator: citric acid, antioxidant: vitamin C.",
                            ImageUrl = "https://images.punkapi.com/v2/9.png",
                            Price = 3.99m,
                            Title = "Mellos Tymián - mata 330ml"
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
