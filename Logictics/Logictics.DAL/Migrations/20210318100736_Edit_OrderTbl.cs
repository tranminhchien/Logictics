using Microsoft.EntityFrameworkCore.Migrations;

namespace Logictics.DAL.Migrations
{
    public partial class Edit_OrderTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "OrderTbl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CategoryId",
                table: "OrderTbl",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
