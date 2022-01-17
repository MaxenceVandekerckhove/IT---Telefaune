using Microsoft.EntityFrameworkCore.Migrations;

namespace IT___Telefaune.Migrations
{
    public partial class CancelEnumerateOnSite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Service",
                table: "Site",
                newName: "TypeService");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TypeService",
                table: "Site",
                newName: "Service");
        }
    }
}
