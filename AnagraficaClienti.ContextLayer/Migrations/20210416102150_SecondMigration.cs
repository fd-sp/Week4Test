using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnagraficaClienti.ContextLayer.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 16, 12, 21, 50, 434, DateTimeKind.Local).AddTicks(5190),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 4, 16, 11, 11, 52, 320, DateTimeKind.Local).AddTicks(9055));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OrderDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 4, 16, 11, 11, 52, 320, DateTimeKind.Local).AddTicks(9055),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2021, 4, 16, 12, 21, 50, 434, DateTimeKind.Local).AddTicks(5190));
        }
    }
}
