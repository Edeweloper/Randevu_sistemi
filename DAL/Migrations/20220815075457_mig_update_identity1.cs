using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class mig_update_identity1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_User_RandevuAlan",
                table: "Randevu");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_User_ZiyaretEdilen",
                table: "Randevu");

            migrationBuilder.DropForeignKey(
                name: "FK_User_IdentityUser_UserId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameIndex(
                name: "IX_User_UserId",
                table: "Users",
                newName: "IX_Users_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "User_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_Users_RandevuAlan",
                table: "Randevu",
                column: "RandevuAlan",
                principalTable: "Users",
                principalColumn: "User_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_Users_ZiyaretEdilen",
                table: "Randevu",
                column: "ZiyaretEdilen",
                principalTable: "Users",
                principalColumn: "User_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_IdentityUser_UserId",
                table: "Users",
                column: "UserId",
                principalTable: "IdentityUser",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_Users_RandevuAlan",
                table: "Randevu");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_Users_ZiyaretEdilen",
                table: "Randevu");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_IdentityUser_UserId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameIndex(
                name: "IX_Users_UserId",
                table: "User",
                newName: "IX_User_UserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "User_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_User_RandevuAlan",
                table: "Randevu",
                column: "RandevuAlan",
                principalTable: "User",
                principalColumn: "User_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_User_ZiyaretEdilen",
                table: "Randevu",
                column: "ZiyaretEdilen",
                principalTable: "User",
                principalColumn: "User_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_IdentityUser_UserId",
                table: "User",
                column: "UserId",
                principalTable: "IdentityUser",
                principalColumn: "Id");
        }
    }
}
