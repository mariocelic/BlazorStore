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
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Buzz",
                    Description = "A light, crisp and bitter IPA brewed with English and American hops. A small batch brewed only once.",
                    ImageUrl = "https://images.punkapi.com/v2/keg.png",
                    Price = 6.99m
                },
                new Product
                {
                    Id = 2,
                    Title = "Trashy Blonde",
                    Description = "A titillating, neurotic, peroxide punk of a Pale Ale. Combining attitude, style, substance, and a little bit of low self esteem for good measure; what would your mother say? The seductive lure of the sassy passion fruit hop proves too much to resist. All that is even before we get onto the fact that there are no additives, preservatives, pasteurization or strings attached. All wrapped up with the customary BrewDog bite and imaginative twist.",
                    ImageUrl = "https://images.punkapi.com/v2/2.png",
                    Price = 7.99m
                },
                new Product
                {
                    Id = 3,
                    Title = "Berliner Weisse With Yuzu - B-Sides",
                    Description = "Japanese citrus fruit intensifies the sour nature of this German classic.",
                    ImageUrl = "https://images.punkapi.com/v2/4.png",
                    Price = 9.99m
                },
                new Product
                {
                    Id = 4,
                    Title = "Avery Brown Dredge",
                    Description = "\"An Imperial Pilsner in collaboration with beer writers. Tradition. Homage. Revolution. We wanted to showcase the awesome backbone of the Czech brewing tradition, the noble Saaz hop, and also tip our hats to the modern beers that rock our world, and the people who make them.",
                    ImageUrl = "https://images.punkapi.com/v2/5.png",
                    Price = 9.99m
                });
        }

        public DbSet<Product> Products { get; set; }
    }
}
