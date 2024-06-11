using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace The_Recipe_House.Data.Migrations
{
    /// <inheritdoc />
    public partial class recipeImg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageURL",
                value: "https://www.allrecipes.com/thmb/IGrCIXMupDR37mMPpZ4DWfBgWM4=/750x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/3661599-how-to-make-perfect-hard-boiled-eggs-Chef-John-1x1-1-bcdf26c1d40645e996e26ae1eedd8d14.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Recipes");
        }
    }
}
