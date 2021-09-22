using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Imovel.Data.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    street = table.Column<string>(type: "varchar(200)", nullable: false),
                    city = table.Column<string>(type: "varchar(50)", nullable: true),
                    complement = table.Column<string>(type: "varchar(50)", nullable: true),
                    district = table.Column<string>(type: "varchar(50)", nullable: true),
                    number = table.Column<string>(type: "varchar(5)", nullable: true),
                    state = table.Column<string>(type: "varchar(2)", nullable: true),
                    zip = table.Column<string>(type: "varchar(8)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "Immobiles",
                columns: table => new
                {
                    ImmobileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImmobileType = table.Column<string>(type: "varchar(30)", nullable: false),
                    AddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Immobiles", x => x.ImmobileId);
                    table.ForeignKey(
                        name: "FK_Immobiles_Adresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Adresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Immobiles_AddressId",
                table: "Immobiles",
                column: "AddressId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Immobiles");

            migrationBuilder.DropTable(
                name: "Adresses");
        }
    }
}
