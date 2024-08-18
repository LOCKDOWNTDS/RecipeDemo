using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recipe.Entities.Migrations
{
    /// <inheritdoc />
    public partial class foodAct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 23, 30, 30, 873, DateTimeKind.Utc).AddTicks(5796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(9522));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Photos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Myusers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(5867),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(2092));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(989),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 729, DateTimeKind.Utc).AddTicks(8930));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231));

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Foods",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 23, 30, 30, 861, DateTimeKind.Utc).AddTicks(2334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 727, DateTimeKind.Utc).AddTicks(5882));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 17, 23, 30, 30, 858, DateTimeKind.Utc).AddTicks(5772),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 726, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 858, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 858, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 858, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 858, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 858, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 858, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 858, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 858, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 858, DateTimeKind.Utc).AddTicks(5772));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "Active", "CreateTime" },
                values: new object[] { true, new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475) });

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Myusers",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 39,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 40,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 41,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 42,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 43,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 44,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 45,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 46,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 47,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 48,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 49,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 50,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 51,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 52,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 53,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 54,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 55,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 56,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 57,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 58,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 59,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 60,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 61,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 62,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 63,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 64,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 65,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 66,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 67,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 68,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 69,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 70,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 71,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 72,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 73,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 74,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 75,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 76,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 77,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 78,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 79,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 80,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 81,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 82,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 83,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 84,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 86,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 87,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 88,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 873, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 8, 17, 23, 30, 30, 873, DateTimeKind.Utc).AddTicks(5796));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Foods");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(9522),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 23, 30, 30, 873, DateTimeKind.Utc).AddTicks(5796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Photos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(5244),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Myusers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(2092),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(5867));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 729, DateTimeKind.Utc).AddTicks(8930),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 23, 30, 30, 872, DateTimeKind.Utc).AddTicks(989));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 728, DateTimeKind.Utc).AddTicks(2231),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 23, 30, 30, 863, DateTimeKind.Utc).AddTicks(1475));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 727, DateTimeKind.Utc).AddTicks(5882),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 23, 30, 30, 861, DateTimeKind.Utc).AddTicks(2334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 8, 15, 18, 30, 39, 726, DateTimeKind.Utc).AddTicks(2013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 8, 17, 23, 30, 30, 858, DateTimeKind.Utc).AddTicks(5772));

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
                column: "CreateTime",
                value: new DateTime(2024, 8, 15, 18, 30, 39, 730, DateTimeKind.Utc).AddTicks(2092));

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
    }
}
