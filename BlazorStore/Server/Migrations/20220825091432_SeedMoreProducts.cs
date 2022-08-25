using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorStore.Server.Migrations
{
    public partial class SeedMoreProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 5, 1, "Re-brewed as a spring seasonal, this beer – which appeared originally as an Equity Punk shareholder creation – retains its trademark spicy, fruity edge. A perfect blend of Belgian Saison and US IPA, crushed peppercorns and heather honey are also added to produce a genuinely unique beer.", "https://images.punkapi.com/v2/6.png", 11.99m, "Electric India" },
                    { 6, 2, "This wine has a delicate bead, with a lovely persistent and creamy mousse. Nuances of stone fruit and melon on the nose are complemented by aromas of fresh cut apple, citrus and bread dough. The wine's linear and crisp acidity is perfectly balanced with the dosage to give the wine a harmonious fullness and length.\r\n\r\nBrut NV is by Stonyfell. It has a critic score of 91 out of 100 based on an aggregation of ratings from our partner sites.", "https://slash2.winevybe.com/wp-content/uploads/Stonyfell-Brut-NV.png", 29.99m, "Stonyfell Brut NV" },
                    { 7, 2, "Although best known for its world-class white wines, this delicious Rouleau red wine should not be missed. The fruits are cleaned from the fruits and vinified in wood for 12-15 months. Classic Auxey-Duresses wine: aromatic, brilliant, filled with notes of crunchy red fruits, cranberries and eret spices.\r\n\r\nAlthough best known for its world-class white wines, this delicious Rouleau red wine should not be missed. The fruits are cleaned from the fruits and vinified in wood for 12-15 months. Classic Auxey-Duresses wine: aromatic, brilliant, filled with notes of crunchy red fruits, cranberries and eret spices.\r\n\r\nAuxey-Duresses 1er Cru Rouge 2017 is a red wine produced in Burgundy, France by Domaine Roulot. It has a critic score of 77 out of 100 based on an aggregation of ratings from our partner sites. This 2017 vintage is available in 750ml volume.", "https://slash1.winevybe.com/wp-content/uploads/Domaine-Roulot-Auxey-Duresses-1er-Cru-Rouge-2017.png", 24.99m, "Domaine Roulot Auxey-Duresses 1er Cru Rouge 2017" },
                    { 8, 2, "Bright lifted aromas of dark plums with spice and liquorice notes. Dark red fruited, layers of plum and blackcurrant flavours, subtle oak and gentle tannins give depth and length on the palate. Matured in oak for 12 - 18 months.\r\n\r\nGR18 Langhorne Creek Shiraz is by Cleanskin. It has a critic score of 95 out of 100 based on an aggregation of ratings from our partner sites.", "https://slash1.winevybe.com/wp-content/uploads/Cleanskin-GR18-Langhorne-Creek-Shiraz.png", 22.99m, "Cleanskin GR18 Langhorne Creek Shiraz" },
                    { 9, 2, "One of the most ideal, aromatic Marlborough Sauvignon Blanc that will accompany brilliantly with seafood dishes. Wonderfully crisp and fragrant with an abundance of rich tropical fruit aromas, Lobster Reef is best enjoyed chilled and shared with family and friends. Now available in a convenient 187mL bottle.\r\n\r\nSauvignon Blanc 187mL is by Lobster Reef. It has a critic score of 64 out of 100 based on an aggregation of ratings from our partner sites.", "https://slash4.winevybe.com/wp-content/uploads/Lobster-Reef-Sauvignon-Blanc-187mL.png", 19.99m, "Lobster Reef Sauvignon Blanc" },
                    { 10, 3, "Ingredients: water, honey 10%, herbs 0,9% (maté, guarana, ginger, ginko, ginseng and more), himalayan salt, carbon dioxide, acidity regulator: citric acid, antioxidant: vitamin C.", "https://images.punkapi.com/v2/7.png", 1.99m, "Mellos Natural energy 330ml" },
                    { 11, 3, "Ingredients: water, honey 10%, herbs 0,7% (rose, hibiscus and more), carbon dioxide, acidity regulator: citric acid, antioxidant: vitamin C.", "https://images.punkapi.com/v2/8.png", 2.99m, "Mellos Ruža - 330ml" },
                    { 12, 3, "Ingredients: water, honey 10%, herbs 0,7% (mint, thyme and more), carbon dioxide, acidity regulator: citric acid, antioxidant: vitamin C.", "https://images.punkapi.com/v2/9.png", 3.99m, "Mellos Tymián - mata 330ml" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
