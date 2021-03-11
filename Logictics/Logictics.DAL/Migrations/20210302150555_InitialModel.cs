using Microsoft.EntityFrameworkCore.Migrations;

namespace Logictics.DAL.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAdmin",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    PassWord = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    Role = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAdmin", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAdmin");
        }
    }
}
