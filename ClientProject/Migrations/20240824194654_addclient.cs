using Microsoft.EntityFrameworkCore.Migrations;

namespace ClientProject.Migrations
{
    public partial class addclient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    contactNumber = table.Column<double>(type: "float", nullable: false),
                    emailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    purpose = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.name);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clients");
        }
    }
}
