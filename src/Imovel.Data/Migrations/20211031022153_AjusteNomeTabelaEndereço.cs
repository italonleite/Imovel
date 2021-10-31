using Microsoft.EntityFrameworkCore.Migrations;

namespace Imovel.Data.Migrations
{
    public partial class AjusteNomeTabelaEndereço : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Immobiles_Adresses_AddressId",
                table: "Immobiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Adresses",
                table: "Adresses");

            migrationBuilder.RenameTable(
                name: "Adresses",
                newName: "Address");

            migrationBuilder.RenameColumn(
                name: "zip",
                table: "Address",
                newName: "Zip");

            migrationBuilder.RenameColumn(
                name: "street",
                table: "Address",
                newName: "Street");

            migrationBuilder.RenameColumn(
                name: "state",
                table: "Address",
                newName: "State");

            migrationBuilder.RenameColumn(
                name: "number",
                table: "Address",
                newName: "Number");

            migrationBuilder.RenameColumn(
                name: "district",
                table: "Address",
                newName: "District");

            migrationBuilder.RenameColumn(
                name: "complement",
                table: "Address",
                newName: "Complement");

            migrationBuilder.RenameColumn(
                name: "city",
                table: "Address",
                newName: "City");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Immobiles_Address_AddressId",
                table: "Immobiles",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Immobiles_Address_AddressId",
                table: "Immobiles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Adresses");

            migrationBuilder.RenameColumn(
                name: "Zip",
                table: "Adresses",
                newName: "zip");

            migrationBuilder.RenameColumn(
                name: "Street",
                table: "Adresses",
                newName: "street");

            migrationBuilder.RenameColumn(
                name: "State",
                table: "Adresses",
                newName: "state");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Adresses",
                newName: "number");

            migrationBuilder.RenameColumn(
                name: "District",
                table: "Adresses",
                newName: "district");

            migrationBuilder.RenameColumn(
                name: "Complement",
                table: "Adresses",
                newName: "complement");

            migrationBuilder.RenameColumn(
                name: "City",
                table: "Adresses",
                newName: "city");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adresses",
                table: "Adresses",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Immobiles_Adresses_AddressId",
                table: "Immobiles",
                column: "AddressId",
                principalTable: "Adresses",
                principalColumn: "AddressId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
