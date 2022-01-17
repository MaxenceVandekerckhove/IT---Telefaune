using Microsoft.EntityFrameworkCore.Migrations;

namespace IT___Telefaune.Migrations
{
    public partial class AddServiceDataToTheSiteTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Service",
                table: "Site",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Service",
                table: "Site");
        }
    }
}
