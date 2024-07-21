using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Recipe.Entities.Migrations
{
    /// <inheritdoc />
    public partial class entitiesChangedNull : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Photos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(8637),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.AlterColumn<string>(
                name: "RecipeExplanation",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PreparationTime",
                table: "Foods",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Foods",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Materials",
                table: "Foods",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "HowManyPerson",
                table: "Foods",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.AlterColumn<string>(
                name: "CookingTime",
                table: "Foods",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(245),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 20, 42, 45, 314, DateTimeKind.Utc).AddTicks(8814),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 20, 22, 59, 180, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 314, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 314, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 314, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 314, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 314, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 314, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 314, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 314, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 314, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 39,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 40,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 41,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 42,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 43,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 44,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 45,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 46,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 47,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 48,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 49,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 50,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 51,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 52,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 53,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 54,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 55,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 56,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 57,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 58,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 59,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 60,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 39,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 40,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 41,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 42,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 43,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 44,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 45,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 46,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 47,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 48,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 49,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 50,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 51,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 52,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 53,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 54,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 55,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 56,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 57,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 58,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 59,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 60,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 61,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 62,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 63,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 64,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 65,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 66,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 67,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 68,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 69,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 70,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 71,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 72,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 73,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 74,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 75,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 76,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 77,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 78,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 79,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 80,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 81,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 82,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 83,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 84,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 86,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 87,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 88,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Photos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 20, 42, 45, 317, DateTimeKind.Utc).AddTicks(915));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(2144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(8637));

            migrationBuilder.AlterColumn<string>(
                name: "RecipeExplanation",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PreparationTime",
                table: "Foods",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Foods",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Materials",
                table: "Foods",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "HowManyPerson",
                table: "Foods",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(5404));

            migrationBuilder.AlterColumn<string>(
                name: "CookingTime",
                table: "Foods",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(4093),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 20, 42, 45, 316, DateTimeKind.Utc).AddTicks(245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 20, 22, 59, 180, DateTimeKind.Utc).AddTicks(9161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 20, 42, 45, 314, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 180, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 180, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 180, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 180, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 180, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 180, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 180, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 180, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 180, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 39,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 40,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 41,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 42,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 43,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 44,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 45,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 46,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 47,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 48,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 49,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 50,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 51,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 52,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 53,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 54,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 55,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 56,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 57,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 58,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 59,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 60,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 39,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 40,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 41,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 42,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 43,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 44,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 45,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 46,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 47,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 48,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 49,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 50,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 51,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 52,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 53,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 54,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 55,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 56,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 57,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 58,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 59,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 60,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 61,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 62,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 63,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 64,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 65,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 66,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 67,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 68,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 69,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 70,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 71,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 72,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 73,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 74,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 75,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 76,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 77,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 78,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 79,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 80,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 81,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 82,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 83,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 84,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 86,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 87,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 88,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "ID", "FoodId", "PhotoPath", "UserId" },
                values: new object[] { 85, 58, "~/img/58.2.jpg", null });
        }
    }
}
