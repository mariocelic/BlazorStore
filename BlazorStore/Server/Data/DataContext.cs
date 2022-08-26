using BlazorStore.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazorStore.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductVariation>()
                .HasKey(pv => new { pv.ProductId, pv.ProductTypeId });

            modelBuilder.Entity<ProductType>().HasData(
                   new ProductType { Id = 1, Name = "Default" },
                   new ProductType { Id = 2, Name = "250 ml" },
                   new ProductType { Id = 3, Name = "330 ml" },
                   new ProductType { Id = 4, Name = "750 ml" },
                   new ProductType { Id = 5, Name = "1 L" },
                   new ProductType { Id = 6, Name = "2L" },
                   new ProductType { Id = 7, Name = "Kegg" }
            );

            modelBuilder.Entity<Category>().HasData(
               new Category
               {
                   Id = 1,
                   Name = "Beers",
                   Url = "beers",
                   
               },
               new Category
               {
                   Id = 2,
                   Name = "Wine",
                   Url = "wines",

               },
               new Category
               {
                   Id = 3,
                   Name = "Soft Drinks",
                   Url = "soft-drinks",

               }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Buzz",
                    Description = "A light, crisp and bitter IPA brewed with English and American hops. A small batch brewed only once.",
                    ImageUrl = "https://images.punkapi.com/v2/keg.png",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Title = "Trashy Blonde",
                    Description = "A titillating, neurotic, peroxide punk of a Pale Ale. Combining attitude, style, substance, and a little bit of low self esteem for good measure; what would your mother say? The seductive lure of the sassy passion fruit hop proves too much to resist. All that is even before we get onto the fact that there are no additives, preservatives, pasteurization or strings attached. All wrapped up with the customary BrewDog bite and imaginative twist.",
                    ImageUrl = "https://images.punkapi.com/v2/2.png",
                    CategoryId=1
                },
                new Product
                {
                    Id = 3,
                    Title = "Berliner Weisse With Yuzu - B-Sides",
                    Description = "Japanese citrus fruit intensifies the sour nature of this German classic.",
                    ImageUrl = "https://images.punkapi.com/v2/4.png",
                    CategoryId=1
                },
                new Product
                {
                    Id = 4,
                    Title = "Avery Brown Dredge",
                    Description = "\"An Imperial Pilsner in collaboration with beer writers. Tradition. Homage. Revolution. We wanted to showcase the awesome backbone of the Czech brewing tradition, the noble Saaz hop, and also tip our hats to the modern beers that rock our world, and the people who make them.",
                    ImageUrl = "https://images.punkapi.com/v2/5.png",
                    CategoryId=1
                },
                new Product
                {
                    Id = 5,
                    Title = "Electric India",
                    Description = "Re-brewed as a spring seasonal, this beer – which appeared originally as an Equity Punk shareholder creation – retains its trademark spicy, fruity edge. A perfect blend of Belgian Saison and US IPA, crushed peppercorns and heather honey are also added to produce a genuinely unique beer.",
                    ImageUrl = "https://images.punkapi.com/v2/6.png",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 6,
                    Title = "Stonyfell Brut NV",
                    Description = "This wine has a delicate bead, with a lovely persistent and creamy mousse. Nuances of stone fruit and melon on the nose are complemented by aromas of fresh cut apple, citrus and bread dough. The wine's linear and crisp acidity is perfectly balanced with the dosage to give the wine a harmonious fullness and length.\r\n\r\nBrut NV is by Stonyfell. It has a critic score of 91 out of 100 based on an aggregation of ratings from our partner sites.",
                    ImageUrl = "https://images.punkapi.com/v2/10.png",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 7,
                    Title = "Domaine Roulot Auxey-Duresses 1er Cru Rouge 2017",
                    Description = "Although best known for its world-class white wines, this delicious Rouleau red wine should not be missed. The fruits are cleaned from the fruits and vinified in wood for 12-15 months. Classic Auxey-Duresses wine: aromatic, brilliant, filled with notes of crunchy red fruits, cranberries and eret spices.\r\n\r\nAlthough best known for its world-class white wines, this delicious Rouleau red wine should not be missed. The fruits are cleaned from the fruits and vinified in wood for 12-15 months. Classic Auxey-Duresses wine: aromatic, brilliant, filled with notes of crunchy red fruits, cranberries and eret spices.\r\n\r\nAuxey-Duresses 1er Cru Rouge 2017 is a red wine produced in Burgundy, France by Domaine Roulot. It has a critic score of 77 out of 100 based on an aggregation of ratings from our partner sites. This 2017 vintage is available in 750ml volume.",
                    ImageUrl = "https://images.punkapi.com/v2/12.png",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 8,
                    Title = "Cleanskin GR18 Langhorne Creek Shiraz",
                    Description = "Bright lifted aromas of dark plums with spice and liquorice notes. Dark red fruited, layers of plum and blackcurrant flavours, subtle oak and gentle tannins give depth and length on the palate. Matured in oak for 12 - 18 months.\r\n\r\nGR18 Langhorne Creek Shiraz is by Cleanskin. It has a critic score of 95 out of 100 based on an aggregation of ratings from our partner sites.",
                    ImageUrl = "https://images.punkapi.com/v2/12.png",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 9,
                    Title = "Lobster Reef Sauvignon Blanc",
                    Description = "One of the most ideal, aromatic Marlborough Sauvignon Blanc that will accompany brilliantly with seafood dishes. Wonderfully crisp and fragrant with an abundance of rich tropical fruit aromas, Lobster Reef is best enjoyed chilled and shared with family and friends. Now available in a convenient 187mL bottle.\r\n\r\nSauvignon Blanc 187mL is by Lobster Reef. It has a critic score of 64 out of 100 based on an aggregation of ratings from our partner sites.",
                    ImageUrl = "https://images.punkapi.com/v2/13.png",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 10,
                    Title = "Mellos Natural energy 330ml",
                    Description = "Ingredients: water, honey 10%, herbs 0,9% (maté, guarana, ginger, ginko, ginseng and more), himalayan salt, carbon dioxide, acidity regulator: citric acid, antioxidant: vitamin C.",
                    ImageUrl = "https://images.punkapi.com/v2/7.png",
                    CategoryId = 3
                },
                new Product
                {
                    Id = 11,
                    Title = "Mellos Ruža - 330ml",
                    Description = "Ingredients: water, honey 10%, herbs 0,7% (rose, hibiscus and more), carbon dioxide, acidity regulator: citric acid, antioxidant: vitamin C.",
                    ImageUrl = "https://images.punkapi.com/v2/8.png",
                    CategoryId = 3
                },
                new Product
                {
                    Id = 12,
                    Title = "Mellos Tymián - mata 330ml",
                    Description = "Ingredients: water, honey 10%, herbs 0,7% (mint, thyme and more), carbon dioxide, acidity regulator: citric acid, antioxidant: vitamin C.",
                    ImageUrl = "https://images.punkapi.com/v2/9.png",
                    CategoryId = 3
                }
            );

            modelBuilder.Entity<ProductVariation>().HasData(
               new ProductVariation
               {
                   ProductId = 1,
                   ProductTypeId = 7,
                   Price = 19.99m,
                   OriginalPrice = 24.99m
               },
               new ProductVariation
               {
                   ProductId = 1,
                   ProductTypeId = 3,
                   Price = 3.99m
               },
               new ProductVariation
               {
                   ProductId = 1,
                   ProductTypeId = 5,
                   Price = 4.99m,
                   OriginalPrice = 29.99m
               },
               new ProductVariation
               {
                   ProductId = 2,
                   ProductTypeId = 3,
                   Price = 7.99m,
                   OriginalPrice = 14.99m
               },
               new ProductVariation
               {
                   ProductId = 3,
                   ProductTypeId = 3,
                   Price = 6.99m
               },
               new ProductVariation
               {
                   ProductId = 4,
                   ProductTypeId = 5,
                   Price = 3.99m
               },
               new ProductVariation
               {
                   ProductId = 4,
                   ProductTypeId = 6,
                   Price = 5.99m
               },
               new ProductVariation
               {
                   ProductId = 4,
                   ProductTypeId = 7,
                   Price = 19.99m
               },
               new ProductVariation
               {
                   ProductId = 5,
                   ProductTypeId = 5,
                   Price = 3.99m,
               },
               new ProductVariation
               {
                   ProductId = 6,
                   ProductTypeId = 5,
                   Price = 3.99m
               },
               new ProductVariation
               {
                   ProductId = 7,
                   ProductTypeId = 3,
                   Price = 19.99m,
                   OriginalPrice = 29.99m
               },
               new ProductVariation
               {
                   ProductId = 7,
                   ProductTypeId = 5,
                   Price = 69.99m
               },
               new ProductVariation
               {
                   ProductId = 7,
                   ProductTypeId = 4,
                   Price = 49.99m,
                   OriginalPrice = 59.99m
               },
               new ProductVariation
               {
                   ProductId = 8,
                   ProductTypeId = 4,
                   Price = 19.99m,
                   OriginalPrice = 24.99m,
               },
               new ProductVariation
               {
                   ProductId = 9,
                   ProductTypeId = 5,
                   Price = 34.99m
               },
               new ProductVariation
               {
                   ProductId = 10,
                   ProductTypeId = 2,
                   Price = 2.99m,
                   OriginalPrice = 2.99m
               },
               new ProductVariation
               {
                   ProductId = 11,
                   ProductTypeId = 2,
                   Price = 2.99m,
                   OriginalPrice = 3.99m
               },
               new ProductVariation
               {
                   ProductId = 12,
                   ProductTypeId = 2,
                   Price = 1.99m,
                   OriginalPrice = 3.99m
               }
           );            
        }

    

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductVariation> ProductVariations { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
    }
}
