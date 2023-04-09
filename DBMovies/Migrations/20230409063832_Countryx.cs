using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBMovies.Migrations
{
    /// <inheritdoc />
    public partial class Countryx : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Codex",
                table: "Countrys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Codex",
                table: "Countrys");
        }
    }
}
