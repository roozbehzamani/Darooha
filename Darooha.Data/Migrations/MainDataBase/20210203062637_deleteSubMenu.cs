using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Darooha.Data.Migrations.MainDataBase
{
    public partial class deleteSubMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Products_Tbl_SubMenues_Tbl_SubMenuID",
                table: "Tbl_Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_SubMenues_Tbl_Menues_MenuId",
                table: "Tbl_SubMenues");

            migrationBuilder.DropTable(
                name: "Tbl_Menues");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_SubMenues_MenuId",
                table: "Tbl_SubMenues");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Products_Tbl_SubMenuID",
                table: "Tbl_Products");

            migrationBuilder.DropColumn(
                name: "MenuId",
                table: "Tbl_SubMenues");

            migrationBuilder.DropColumn(
                name: "Tbl_SubMenuID",
                table: "Tbl_Products");

            migrationBuilder.AddColumn<string>(
                name: "MenuImage",
                table: "Tbl_SubMenues",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Tbl_MenuID",
                table: "Tbl_Products",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Products_Tbl_MenuID",
                table: "Tbl_Products",
                column: "Tbl_MenuID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Products_Tbl_SubMenues_Tbl_MenuID",
                table: "Tbl_Products",
                column: "Tbl_MenuID",
                principalTable: "Tbl_SubMenues",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tbl_Products_Tbl_SubMenues_Tbl_MenuID",
                table: "Tbl_Products");

            migrationBuilder.DropIndex(
                name: "IX_Tbl_Products_Tbl_MenuID",
                table: "Tbl_Products");

            migrationBuilder.DropColumn(
                name: "MenuImage",
                table: "Tbl_SubMenues");

            migrationBuilder.DropColumn(
                name: "Tbl_MenuID",
                table: "Tbl_Products");

            migrationBuilder.AddColumn<string>(
                name: "MenuId",
                table: "Tbl_SubMenues",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Tbl_SubMenuID",
                table: "Tbl_Products",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Tbl_Menues",
                columns: table => new
                {
                    ID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MenuImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MenuName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Menues", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_SubMenues_MenuId",
                table: "Tbl_SubMenues",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_Tbl_Products_Tbl_SubMenuID",
                table: "Tbl_Products",
                column: "Tbl_SubMenuID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_Products_Tbl_SubMenues_Tbl_SubMenuID",
                table: "Tbl_Products",
                column: "Tbl_SubMenuID",
                principalTable: "Tbl_SubMenues",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tbl_SubMenues_Tbl_Menues_MenuId",
                table: "Tbl_SubMenues",
                column: "MenuId",
                principalTable: "Tbl_Menues",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
