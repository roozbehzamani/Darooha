using Microsoft.EntityFrameworkCore.Migrations;

namespace Darooha.Data.Migrations.MainDataBase
{
    public partial class editBrand : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tbl_BrandsID",
                table: "Tbl_Products",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Products_Tbl_BrandsID",
                table: "Tbl_Products",
                column: "Tbl_BrandsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Products_Tbl_Brands_Tbl_BrandsID",
                table: "Tbl_Products",
                column: "Tbl_BrandsID",
                principalTable: "Tbl_Brands",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Products_Tbl_Brands_Tbl_BrandsID",
                table: "Tbl_Products");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Products_Tbl_BrandsID",
                table: "Tbl_Products");

            migrationBuilder.DropColumn(
                name: "Tbl_BrandsID",
                table: "Tbl_Products");
        }
    }
}
