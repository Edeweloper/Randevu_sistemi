using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Randevu_durumu",
                table: "Randevu",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_Randevu_durumu",
                table: "Randevu",
                column: "Randevu_durumu");

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_Randevu_durumu_Randevu_durumu",
                table: "Randevu",
                column: "Randevu_durumu",
                principalTable: "Randevu_durumu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_Randevu_durumu_Randevu_durumu",
                table: "Randevu");

            migrationBuilder.DropIndex(
                name: "IX_Randevu_Randevu_durumu",
                table: "Randevu");

            migrationBuilder.DropColumn(
                name: "Randevu_durumu",
                table: "Randevu");
        }
    }
}
