using Microsoft.EntityFrameworkCore.Migrations;

namespace Logictics.DAL.Migrations
{
    public partial class NewData : Migration
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
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreateDate = table.Column<double>(nullable: true),
                    ModifyDate = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAdmin", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "UserAdmin",
                columns: new[] { "Id", "CreateDate", "ModifyDate", "PassWord", "Role", "Status", "UserName" },
                values: new object[] { "69bd714f-9576-45ba-b5b7-f00649be00de", null, null, "7c4a8d9ca3762af61e59520943dc26494f8941b", "ADMIN", "ACTIVE", "admin" });

            migrationBuilder.InsertData(
                table: "UserAdmin",
                columns: new[] { "Id", "CreateDate", "ModifyDate", "PassWord", "Role", "Status", "UserName" },
                values: new object[] { "69bd714f-9576-45ba-b5b7-f00649be00df", 1.0, null, "7c4a8d9ca3762af61e59520943dc26494f8941b", "CLIENT", "ACTIVE", "ChienClient" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAdmin");
        }
    }
}
