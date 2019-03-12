using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StuttgartCore.Migrations
{
    public partial class rechnungen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rechnungens",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    KundenID = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    KopfText = table.Column<string>(nullable: true),
                    Summe = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rechnungens", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Positionens",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RechnungenID = table.Column<int>(nullable: false),
                    Anzahl = table.Column<int>(nullable: false),
                    Preis = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positionens", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Positionens_Rechnungens_RechnungenID",
                        column: x => x.RechnungenID,
                        principalTable: "Rechnungens",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Positionens_RechnungenID",
                table: "Positionens",
                column: "RechnungenID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Positionens");

            migrationBuilder.DropTable(
                name: "Rechnungens");
        }
    }
}
