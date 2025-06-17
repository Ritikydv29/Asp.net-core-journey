using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleToAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddMarksToScore : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Marks",
                table: "Scores",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Marks",
                table: "Scores");
        }
    }
}
