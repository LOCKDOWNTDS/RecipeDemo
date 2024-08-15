using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recipe.Entities.Migrations
{
    /// <inheritdoc />
    public partial class MyUserActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(9522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Photos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Myusers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(2092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 14, 48, 823, DateTimeKind.Utc).AddTicks(8501));

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Myusers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 729, DateTimeKind.Utc).AddTicks(8930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 14, 48, 823, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 727, DateTimeKind.Utc).AddTicks(5882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 14, 48, 818, DateTimeKind.Utc).AddTicks(2754));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 726, DateTimeKind.Utc).AddTicks(2013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 12, 15, 14, 48, 815, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 726, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 726, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 726, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 726, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 726, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 726, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 726, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 726, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 726, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 39,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 40,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 41,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 42,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 43,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 44,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 45,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 46,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 47,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 48,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 49,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 50,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 51,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 52,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 53,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 54,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 55,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 56,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 57,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 58,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 59,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 60,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 729, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 729, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 729, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 729, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 729, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 729, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 729, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 729, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 729, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 729, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Myusers",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 39,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 40,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 41,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 42,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 43,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 44,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 45,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 46,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 47,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 48,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 49,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 50,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 51,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 52,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 53,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 54,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 55,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 56,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 57,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 58,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 59,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 60,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 61,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 62,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 63,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 64,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 65,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 66,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 67,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 68,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 69,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 70,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 71,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 72,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 73,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 74,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 75,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 76,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 77,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 78,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 79,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 80,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 81,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 82,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 83,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 84,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 86,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 87,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 88,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(9522));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Myusers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(7324),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Photos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Myusers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 14, 48, 823, DateTimeKind.Utc).AddTicks(8501),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(2092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 14, 48, 823, DateTimeKind.Utc).AddTicks(3391),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 729, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 14, 48, 818, DateTimeKind.Utc).AddTicks(2754),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 727, DateTimeKind.Utc).AddTicks(5882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 12, 15, 14, 48, 815, DateTimeKind.Utc).AddTicks(8887),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 726, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 815, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 815, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 815, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 815, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 815, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 815, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 815, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 815, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 815, DateTimeKind.Utc).AddTicks(8887));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 39,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 40,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 41,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 42,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 43,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 44,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 45,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 46,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 47,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 48,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 49,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 50,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 51,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 52,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 53,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 54,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 55,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 56,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 57,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 58,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 59,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 60,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 819, DateTimeKind.Utc).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 823, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 823, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 823, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 823, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 823, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 823, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 823, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 823, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 823, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 823, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Myusers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 823, DateTimeKind.Utc).AddTicks(8501));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 39,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 40,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 41,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 42,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 43,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 44,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 45,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 46,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 47,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 48,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 49,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 50,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 51,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 52,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 53,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 54,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 55,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 56,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 57,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 58,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 59,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 60,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 61,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 62,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 63,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 64,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 65,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 66,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 67,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 68,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 69,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 70,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 71,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 72,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 73,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 74,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 75,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 76,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 77,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 78,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 79,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 80,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 81,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 82,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 83,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 84,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 86,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 87,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 88,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(7324));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 8, 12, 15, 14, 48, 824, DateTimeKind.Utc).AddTicks(7324));
        }
    }
}
