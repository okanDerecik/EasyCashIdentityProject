using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EasyCashIdentityProject.DataAccessLayer.Migrations
{
    public partial class mig_add_relation_customerAccount_appUSer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AppUSerID",
                table: "CustomerAccounts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAccounts_AppUSerID",
                table: "CustomerAccounts",
                column: "AppUSerID");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppUSerID",
                table: "CustomerAccounts",
                column: "AppUSerID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerAccounts_AspNetUsers_AppUSerID",
                table: "CustomerAccounts");

            migrationBuilder.DropIndex(
                name: "IX_CustomerAccounts_AppUSerID",
                table: "CustomerAccounts");

            migrationBuilder.DropColumn(
                name: "AppUSerID",
                table: "CustomerAccounts");
        }
    }
}
