using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorStore.Server.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "A light, crisp and bitter IPA brewed with English and American hops. A small batch brewed only once.", "https://images.punkapi.com/v2/keg.png", 6.99m, "Buzz" },
                    { 2, "A titillating, neurotic, peroxide punk of a Pale Ale. Combining attitude, style, substance, and a little bit of low self esteem for good measure; what would your mother say? The seductive lure of the sassy passion fruit hop proves too much to resist. All that is even before we get onto the fact that there are no additives, preservatives, pasteurization or strings attached. All wrapped up with the customary BrewDog bite and imaginative twist.", "https://images.punkapi.com/v2/2.png", 7.99m, "Trashy Blonde" },
                    { 3, "Japanese citrus fruit intensifies the sour nature of this German classic.", "https://images.punkapi.com/v2/4.png", 9.99m, "Berliner Weisse With Yuzu - B-Sides" },
                    { 4, "\"An Imperial Pilsner in collaboration with beer writers. Tradition. Homage. Revolution. We wanted to showcase the awesome backbone of the Czech brewing tradition, the noble Saaz hop, and also tip our hats to the modern beers that rock our world, and the people who make them.", "https://images.punkapi.com/v2/5.png", 9.99m, "Avery Brown Dredge" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
