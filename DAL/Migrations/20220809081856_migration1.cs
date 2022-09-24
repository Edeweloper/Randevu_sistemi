using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arama_tipi",
                columns: table => new
                {
                    Arama_tipi_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Arama_tipi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arama_tipi", x => x.Arama_tipi_id);
                });

            migrationBuilder.CreateTable(
                name: "Arayan_tipi",
                columns: table => new
                {
                    Arayan_tipi_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Arayan_tipi = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arayan_tipi", x => x.Arayan_tipi_id);
                });

            migrationBuilder.CreateTable(
                name: "Randevu_durumu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    randevu_durumu = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevu_durumu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    User_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Username = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.User_id);
                });

            migrationBuilder.CreateTable(
                name: "Arama",
                columns: table => new
                {
                    Arama_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Arama_tipi_id = table.Column<int>(type: "integer", nullable: false),
                    Arayan_tipi_id = table.Column<int>(type: "integer", nullable: false),
                    Ad = table.Column<string>(type: "text", nullable: false),
                    Tel = table.Column<string>(type: "text", nullable: false),
                    Konu = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arama", x => x.Arama_id);
                    table.ForeignKey(
                        name: "FK_Arama_Arama_tipi_Arama_tipi_id",
                        column: x => x.Arama_tipi_id,
                        principalTable: "Arama_tipi",
                        principalColumn: "Arama_tipi_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Arama_Arayan_tipi_Arayan_tipi_id",
                        column: x => x.Arayan_tipi_id,
                        principalTable: "Arayan_tipi",
                        principalColumn: "Arayan_tipi_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Randevu",
                columns: table => new
                {
                    Randevu_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Randevuya_Gelen = table.Column<string>(type: "text", nullable: false),
                    Telefon = table.Column<string>(type: "text", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    StartTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    EndTime = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Konu = table.Column<string>(type: "text", nullable: false),
                    RandevuAlan = table.Column<int>(type: "integer", nullable: false),
                    ZiyaretEdilen = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Randevu", x => x.Randevu_id);
                    table.ForeignKey(
                        name: "FK_Randevu_User_RandevuAlan",
                        column: x => x.RandevuAlan,
                        principalTable: "User",
                        principalColumn: "User_id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Randevu_User_ZiyaretEdilen",
                        column: x => x.ZiyaretEdilen,
                        principalTable: "User",
                        principalColumn: "User_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arama_Arama_tipi_id",
                table: "Arama",
                column: "Arama_tipi_id");

            migrationBuilder.CreateIndex(
                name: "IX_Arama_Arayan_tipi_id",
                table: "Arama",
                column: "Arayan_tipi_id");

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_RandevuAlan",
                table: "Randevu",
                column: "RandevuAlan");

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_ZiyaretEdilen",
                table: "Randevu",
                column: "ZiyaretEdilen");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arama");

            migrationBuilder.DropTable(
                name: "Randevu");

            migrationBuilder.DropTable(
                name: "Randevu_durumu");

            migrationBuilder.DropTable(
                name: "Arama_tipi");

            migrationBuilder.DropTable(
                name: "Arayan_tipi");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
