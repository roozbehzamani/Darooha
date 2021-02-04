using Microsoft.EntityFrameworkCore.Migrations;

namespace Darooha.Data.Migrations.MainDataBase
{
    public partial class editSubMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Products_Tbl_SubMenues_Tbl_MenuID",
                table: "Tbl_Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_SubMenues",
                table: "Tbl_SubMenues");

            migrationBuilder.RenameTable(
                name: "Tbl_SubMenues",
                newName: "Tbl_Menues");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_Menues",
                table: "Tbl_Menues",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Products_Tbl_Menues_Tbl_MenuID",
                table: "Tbl_Products",
                column: "Tbl_MenuID",
                principalTable: "Tbl_Menues",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Products_Tbl_Menues_Tbl_MenuID",
                table: "Tbl_Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tbl_Menues",
                table: "Tbl_Menues");

            migrationBuilder.RenameTable(
                name: "Tbl_Menues",
                newName: "Tbl_SubMenues");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tbl_SubMenues",
                table: "Tbl_SubMenues",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Products_Tbl_SubMenues_Tbl_MenuID",
                table: "Tbl_Products",
                column: "Tbl_MenuID",
                principalTable: "Tbl_SubMenues",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
