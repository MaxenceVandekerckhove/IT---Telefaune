using Microsoft.EntityFrameworkCore.Migrations;

namespace IT___Telefaune.Migrations
{
    public partial class UpdateTableSiteWithName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SiteModel",
                table: "SiteModel");

            migrationBuilder.RenameTable(
                name: "SiteModel",
                newName: "Site");

            migrationBuilder.AddColumn<string>(
                name: "Nom",
                table: "Site",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Site",
                table: "Site",
                column: "SiteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Site",
                table: "Site");

            migrationBuilder.DropColumn(
                name: "Nom",
                table: "Site");

            migrationBuilder.RenameTable(
                name: "Site",
                newName: "SiteModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SiteModel",
                table: "SiteModel",
                column: "SiteId");
        }
    }
}
