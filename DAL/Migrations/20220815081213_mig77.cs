using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DAL.Migrations
{
    public partial class mig77 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_Users_RandevuAlan",
                table: "Randevu");

            migrationBuilder.DropForeignKey(
                name: "FK_Randevu_Users_ZiyaretEdilen",
                table: "Randevu");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "IdentityUser");

            migrationBuilder.DropIndex(
                name: "IX_Randevu_RandevuAlan",
                table: "Randevu");

            migrationBuilder.DropIndex(
                name: "IX_Randevu_ZiyaretEdilen",
                table: "Randevu");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentityUser",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Password = table.Column<string>(type: "text", nullable: false),
                    Surname = table.Column<string>(type: "text", nullable: false),
                    Username = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_id);
                    table.ForeignKey(
                        name: "FK_Users_IdentityUser_UserId",
                        column: x => x.UserId,
                        principalTable: "IdentityUser",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_RandevuAlan",
                table: "Randevu",
                column: "RandevuAlan");

            migrationBuilder.CreateIndex(
                name: "IX_Randevu_ZiyaretEdilen",
                table: "Randevu",
                column: "ZiyaretEdilen");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserId",
                table: "Users",
                column: "UserId");

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
        }
    }
}
