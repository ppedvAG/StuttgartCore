using Microsoft.EntityFrameworkCore.Migrations;

namespace StuttgartCore.Migrations
{
    public partial class rechnungen1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Positionens",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "Positionens");
        }
    }
}
