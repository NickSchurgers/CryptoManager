using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CryptoManager.Data.Migrations
{
    public partial class AddExchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ExchangeId",
                table: "Accounts",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Exchanges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    TypeId = table.Column<Guid>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exchanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exchanges_Exchanges_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Exchanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accounts_ExchangeId",
                table: "Accounts",
                column: "ExchangeId");

            migrationBuilder.CreateIndex(
                name: "IX_Exchanges_TypeId",
                table: "Exchanges",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Accounts_Exchanges_ExchangeId",
                table: "Accounts",
                column: "ExchangeId",
                principalTable: "Exchanges",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accounts_Exchanges_ExchangeId",
                table: "Accounts");

            migrationBuilder.DropTable(
                name: "Exchanges");

            migrationBuilder.DropIndex(
                name: "IX_Accounts_ExchangeId",
                table: "Accounts");

            migrationBuilder.DropColumn(
                name: "ExchangeId",
                table: "Accounts");
        }
    }
}
