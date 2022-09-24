using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class migration_tumtabloguncellestirme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arama_Arama_tipi_Arama_tipi_id",
                table: "Arama");

            migrationBuilder.DropForeignKey(
                name: "FK_Arama_Arayan_tipi_Arayan_tipi_id",
                table: "Arama");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_Randevu_durumu_Randevu_durumu",
                table: "Randevu");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Randevu");

            migrationBuilder.RenameColumn(
                name: "randevu_durumu",
                table: "Randevu_durumu",
                newName: "Randevu_Durumu");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Randevu_durumu",
                newName: "RandevuID");

            migrationBuilder.RenameColumn(
                name: "ZiyaretEdilen",
                table: "Randevu",
                newName: "Ziyaret_EdilenKisiId");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "Randevu",
                newName: "Start_Time");

            migrationBuilder.RenameColumn(
                name: "Randevu_durumu",
                table: "Randevu",
                newName: "Randevu_KaydedenId");

            migrationBuilder.RenameColumn(
                name: "RandevuAlan",
                table: "Randevu",
                newName: "Randevu_DurumuId");

            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "Randevu",
                newName: "End_Time");

            migrationBuilder.RenameIndex(
                name: "IX_Randevu_Randevu_durumu",
                table: "Randevu",
                newName: "IX_Randevu_Randevu_KaydedenId");

            migrationBuilder.RenameColumn(
                name: "Arayan_tipi_id",
                table: "Arama",
                newName: "KaydedenId");

            migrationBuilder.RenameColumn(
                name: "Arama_tipi_id",
                table: "Arama",
                newName: "ArayanTipiId");

            migrationBuilder.RenameIndex(
                name: "IX_Arama_Arayan_tipi_id",
                table: "Arama",
                newName: "IX_Arama_KaydedenId");

            migrationBuilder.RenameIndex(
                name: "IX_Arama_Arama_tipi_id",
                table: "Arama",
                newName: "IX_Arama_ArayanTipiId");

            migrationBuilder.AddColumn<int>(
                name: "KullanıcıRandevuId",
                table: "Randevu",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AramaTipiId",
                table: "Arama",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ArananId",
                table: "Arama",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Aranma_Zamanı",
                table: "Arama",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_Randevu_DurumuId",
                table: "Randevu",
                column: "Randevu_DurumuId");

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_Ziyaret_EdilenKisiId",
                table: "Randevu",
                column: "Ziyaret_EdilenKisiId");

            migrationBuilder.CreateIndex(
                name: "IX_Arama_AramaTipiId",
                table: "Arama",
                column: "AramaTipiId");

            migrationBuilder.CreateIndex(
                name: "IX_Arama_ArananId",
                table: "Arama",
                column: "ArananId");

            migrationBuilder.AddForeignKey(
                name: "FK_Arama_Arama_tipi_AramaTipiId",
                table: "Arama",
                column: "AramaTipiId",
                principalTable: "Arama_tipi",
                principalColumn: "Arama_tipi_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Arama_Arayan_tipi_ArayanTipiId",
                table: "Arama",
                column: "ArayanTipiId",
                principalTable: "Arayan_tipi",
                principalColumn: "Arayan_tipi_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Arama_AspNetUsers_ArananId",
                table: "Arama",
                column: "ArananId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Arama_AspNetUsers_KaydedenId",
                table: "Arama",
                column: "KaydedenId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_AspNetUsers_Randevu_KaydedenId",
                table: "Randevu",
                column: "Randevu_KaydedenId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_AspNetUsers_Ziyaret_EdilenKisiId",
                table: "Randevu",
                column: "Ziyaret_EdilenKisiId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_Randevu_durumu_Randevu_DurumuId",
                table: "Randevu",
                column: "Randevu_DurumuId",
                principalTable: "Randevu_durumu",
                principalColumn: "RandevuID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Arama_Arama_tipi_AramaTipiId",
                table: "Arama");

            migrationBuilder.DropForeignKey(
                name: "FK_Arama_Arayan_tipi_ArayanTipiId",
                table: "Arama");

            migrationBuilder.DropForeignKey(
                name: "FK_Arama_AspNetUsers_ArananId",
                table: "Arama");

            migrationBuilder.DropForeignKey(
                name: "FK_Arama_AspNetUsers_KaydedenId",
                table: "Arama");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_AspNetUsers_Randevu_KaydedenId",
                table: "Randevu");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_AspNetUsers_Ziyaret_EdilenKisiId",
                table: "Randevu");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_Randevu_durumu_Randevu_DurumuId",
                table: "Randevu");

            migrationBuilder.DropIndex(
                name: "IX_Randevu_Randevu_DurumuId",
                table: "Randevu");

            migrationBuilder.DropIndex(
                name: "IX_Randevu_Ziyaret_EdilenKisiId",
                table: "Randevu");

            migrationBuilder.DropIndex(
                name: "IX_Arama_AramaTipiId",
                table: "Arama");

            migrationBuilder.DropIndex(
                name: "IX_Arama_ArananId",
                table: "Arama");

            migrationBuilder.DropColumn(
                name: "KullanıcıRandevuId",
                table: "Randevu");

            migrationBuilder.DropColumn(
                name: "AramaTipiId",
                table: "Arama");

            migrationBuilder.DropColumn(
                name: "ArananId",
                table: "Arama");

            migrationBuilder.DropColumn(
                name: "Aranma_Zamanı",
                table: "Arama");

            migrationBuilder.RenameColumn(
                name: "Randevu_Durumu",
                table: "Randevu_durumu",
                newName: "randevu_durumu");

            migrationBuilder.RenameColumn(
                name: "RandevuID",
                table: "Randevu_durumu",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Ziyaret_EdilenKisiId",
                table: "Randevu",
                newName: "ZiyaretEdilen");

            migrationBuilder.RenameColumn(
                name: "Start_Time",
                table: "Randevu",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "Randevu_KaydedenId",
                table: "Randevu",
                newName: "Randevu_durumu");

            migrationBuilder.RenameColumn(
                name: "Randevu_DurumuId",
                table: "Randevu",
                newName: "RandevuAlan");

            migrationBuilder.RenameColumn(
                name: "End_Time",
                table: "Randevu",
                newName: "EndTime");

            migrationBuilder.RenameIndex(
                name: "IX_Randevu_Randevu_KaydedenId",
                table: "Randevu",
                newName: "IX_Randevu_Randevu_durumu");

            migrationBuilder.RenameColumn(
                name: "KaydedenId",
                table: "Arama",
                newName: "Arayan_tipi_id");

            migrationBuilder.RenameColumn(
                name: "ArayanTipiId",
                table: "Arama",
                newName: "Arama_tipi_id");

            migrationBuilder.RenameIndex(
                name: "IX_Arama_KaydedenId",
                table: "Arama",
                newName: "IX_Arama_Arayan_tipi_id");

            migrationBuilder.RenameIndex(
                name: "IX_Arama_ArayanTipiId",
                table: "Arama",
                newName: "IX_Arama_Arama_tipi_id");

            migrationBuilder.AddColumn<DateOnly>(
                name: "Date",
                table: "Randevu",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddForeignKey(
                name: "FK_Arama_Arama_tipi_Arama_tipi_id",
                table: "Arama",
                column: "Arama_tipi_id",
                principalTable: "Arama_tipi",
                principalColumn: "Arama_tipi_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Arama_Arayan_tipi_Arayan_tipi_id",
                table: "Arama",
                column: "Arayan_tipi_id",
                principalTable: "Arayan_tipi",
                principalColumn: "Arayan_tipi_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Randevu_Randevu_durumu_Randevu_durumu",
                table: "Randevu",
                column: "Randevu_durumu",
                principalTable: "Randevu_durumu",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
