using Microsoft.EntityFrameworkCore.Migrations;

namespace IT___Telefaune.Migrations
{
    public partial class AddSalarieTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Salarie",
                columns: table => new
                {
                    SalarieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelephoneFixe = table.Column<int>(type: "int", nullable: false),
                    TelephonePortable = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeService = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomSite = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salarie", x => x.SalarieId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Salarie");
        }
    }
}
