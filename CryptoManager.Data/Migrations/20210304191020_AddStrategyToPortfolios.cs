using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CryptoManager.Data.Migrations
{
    public partial class AddStrategyToPortfolios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Strategy",
                table: "Portfolios");

            migrationBuilder.AddColumn<Guid>(
                name: "StrategyId",
                table: "Portfolios",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Strategy",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    TradingStrategy = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Strategy", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Portfolios_StrategyId",
                table: "Portfolios",
                column: "StrategyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portfolios_Strategy_StrategyId",
                table: "Portfolios",
                column: "StrategyId",
                principalTable: "Strategy",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portfolios_Strategy_StrategyId",
                table: "Portfolios");

            migrationBuilder.DropTable(
                name: "Strategy");

            migrationBuilder.DropIndex(
                name: "IX_Portfolios_StrategyId",
                table: "Portfolios");

            migrationBuilder.DropColumn(
                name: "StrategyId",
                table: "Portfolios");

            migrationBuilder.AddColumn<int>(
                name: "Strategy",
                table: "Portfolios",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
