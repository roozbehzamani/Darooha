using Microsoft.EntityFrameworkCore.Migrations;

namespace Darooha.Data.Migrations.MainDataBase
{
    public partial class addDiscount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discount",
                table: "Tbl_Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discount",
                table: "Tbl_Products");
        }
    }
}
