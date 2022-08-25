using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorStore.Server.Migrations
{
    public partial class ChangeSomeProductsAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://images.punkapi.com/v2/12.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "ImageUrl",
                value: "https://images.punkapi.com/v2/11.png");
        }
    }
}
