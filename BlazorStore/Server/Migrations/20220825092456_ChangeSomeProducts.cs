using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorStore.Server.Migrations
{
    public partial class ChangeSomeProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://images.punkapi.com/v2/10.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://images.punkapi.com/v2/11.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://images.punkapi.com/v2/12.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://images.punkapi.com/v2/13.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://slash2.winevybe.com/wp-content/uploads/Stonyfell-Brut-NV.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://slash1.winevybe.com/wp-content/uploads/Domaine-Roulot-Auxey-Duresses-1er-Cru-Rouge-2017.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "ImageUrl",
                value: "https://slash1.winevybe.com/wp-content/uploads/Cleanskin-GR18-Langhorne-Creek-Shiraz.png");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "ImageUrl",
                value: "https://slash4.winevybe.com/wp-content/uploads/Lobster-Reef-Sauvignon-Blanc-187mL.png");
        }
    }
}
