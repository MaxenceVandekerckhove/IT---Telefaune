using Microsoft.EntityFrameworkCore.Migrations;

namespace IT___Telefaune.Migrations
{
    public partial class AddSalarieTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdService",
                table: "Service",
                newName: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServiceId",
                table: "Service",
                newName: "IdService");
        }
    }
}
