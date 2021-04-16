using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnagraficaClienti.ContextLayer.Migrations
{
    public partial class LastMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Clients_ClientId",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 16, 12, 46, 16, 245, DateTimeKind.Local).AddTicks(3120),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 16, 12, 41, 26, 300, DateTimeKind.Local).AddTicks(7242));

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Orders",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Clients_ClientId",
                table: "Orders",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Clients_ClientId",
                table: "Orders");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 16, 12, 41, 26, 300, DateTimeKind.Local).AddTicks(7242),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 16, 12, 46, 16, 245, DateTimeKind.Local).AddTicks(3120));

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Orders",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Clients_ClientId",
                table: "Orders",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
