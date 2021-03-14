using Microsoft.EntityFrameworkCore.Migrations;

namespace Logictics.DAL.Migrations
{
    public partial class Add_Order : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderDetailTbl",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ProductCategoryId = table.Column<string>(nullable: true),
                    ProductCode = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Quality = table.Column<string>(nullable: true),
                    Weight = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    OrderId = table.Column<string>(nullable: true),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreateDate = table.Column<double>(nullable: true),
                    ModifyDate = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetailTbl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderTbl",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Store = table.Column<string>(nullable: true),
                    TotalWeight = table.Column<string>(nullable: true),
                    CustomerPhone = table.Column<string>(nullable: true),
                    Status = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreateDate = table.Column<double>(nullable: true),
                    ModifyData = table.Column<double>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderTbl", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetailTbl");

            migrationBuilder.DropTable(
                name: "OrderTbl");
        }
    }
}
