using Microsoft.EntityFrameworkCore.Migrations;

namespace Logictics.DAL.Migrations
{
    public partial class EditTotalWeight : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModifyData",
                table: "OrderTbl");

            migrationBuilder.AlterColumn<int>(
                name: "TotalWeight",
                table: "OrderTbl",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ModifyDate",
                table: "OrderTbl",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModifyDate",
                table: "OrderTbl");

            migrationBuilder.AlterColumn<string>(
                name: "TotalWeight",
                table: "OrderTbl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<double>(
                name: "ModifyData",
                table: "OrderTbl",
                type: "float",
                nullable: true);
        }
    }
}
