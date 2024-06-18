using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace The_Recipe_House.Data.Migrations
{
    /// <inheritdoc />
    public partial class addcomments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CookTime", "Description", "ImageURL", "Ingredients", "Instructions", "PrepTime", "Title" },
                values: new object[] { 1, 5, "An easy breakfast item that is rich in protein, but low on calories!", "https://www.allrecipes.com/thmb/IGrCIXMupDR37mMPpZ4DWfBgWM4=/750x0/filters:no_upscale():max_bytes(150000):strip_icc():format(webp)/3661599-how-to-make-perfect-hard-boiled-eggs-Chef-John-1x1-1-bcdf26c1d40645e996e26ae1eedd8d14.jpg", "6 eggs", "1. Place eggs in a saucepan and pour in cold water to cover; place over high heat. When water starts to simmer and eggs start to dance around a little, turn off heat, cover the pan quickly with a lid, and let stand for 17 minutes. Don't peek.\r\n\r\n2. Pour out hot water and pour cold water over eggs. Drain and refill with cold water; let stand until eggs are cool, about 20 minutes.\r\n\r\n3. Peel eggs under running water.", 5, "Hard boiled Eggs" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
