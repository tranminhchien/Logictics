using Microsoft.EntityFrameworkCore.Migrations;

namespace Logictics.DAL.Migrations
{
    public partial class Edit_OrderdetailTbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Weight",
                table: "OrderDetailTbl",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Quality",
                table: "OrderDetailTbl",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "OrderDetailTbl",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Weight",
                table: "OrderDetailTbl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Quality",
                table: "OrderDetailTbl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "OrderDetailTbl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
