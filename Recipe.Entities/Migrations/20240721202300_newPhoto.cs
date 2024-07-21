using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Recipe.Entities.Migrations
{
    /// <inheritdoc />
    public partial class newPhoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Photos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(2144),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(4093),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 13, 43, 48, 113, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 20, 22, 59, 180, DateTimeKind.Utc).AddTicks(9161),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 13, 43, 48, 111, DateTimeKind.Utc).AddTicks(6088));

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

            migrationBuilder.InsertData(
                table: "CategoryFoods",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[,]
                {
                    { 9, 12 },
                    { 9, 44 },
                    { 9, 52 }
                });

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
                columns: new[] { "CookingTime", "CreateTime", "HowManyPerson", "Materials", "Name", "PreparationTime", "RecipeExplanation" },
                values: new object[] { "2 saat", new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330), "10 kişilik", "Buğday, nohut, kuru fasulye, kuru kayısı, kuru incir, kuru üzüm, ceviz, fındık, nar, su, şeker", "Aşure", "30 dakika", "Buğday, nohut ve kuru fasulyeyi ayrı ayrı haşlayın. Kuru kayısı, kuru incir ve kuru üzümü küçük doğrayın. Tüm malzemeleri büyük bir tencereye alın, su ekleyin ve kaynatın. Şekeri ekleyin ve karıştırarak pişirin. Aşure kıvamına gelince ocaktan alın ve kaselere dökün. Üzerini ceviz, fındık ve nar ile süsleyerek soğuk servis yapın." });

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
                columns: new[] { "CookingTime", "CreateTime", "HowManyPerson", "Materials", "Name", "PreparationTime", "RecipeExplanation" },
                values: new object[] { "10 dakika", new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330), "6 kişilik", "Güllaç yaprağı, süt, şeker, gül suyu, ceviz, nar", "Güllaç", "20 dakika", "Sütü ve şekeri ısıtın. Güllaç yapraklarını sütle ıslatarak üst üste dizin. Aralarına ceviz serpin. Gül suyu ekleyin. Üzerine nar taneleri ile süsleyin ve soğuk servis yapın." });

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
                columns: new[] { "CookingTime", "CreateTime", "HowManyPerson", "Materials", "Name", "PreparationTime", "RecipeExplanation" },
                values: new object[] { "20 dakika", new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330), "6 kişilik", "Kadayıf, tuzsuz peynir, tereyağı, şeker, su, limon", "Künefe", "30 dakika", "Kadayıfı tereyağı ile karıştırın ve yarısını tepsiye yayın. Üzerine peyniri koyun ve kalan kadayıfı üzerine kapatın. Orta ateşte altın rengi alana kadar pişirin. Şerbet için şeker, su ve limonu kaynatın ve sıcak künefenin üzerine dökün." });

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

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "ID", "FoodId", "PhotoPath", "UserId" },
                values: new object[,]
                {
                    { 24, 15, "~/img/15.1.jpg", null },
                    { 25, 15, "~/img/15.2.jpg", null },
                    { 26, 16, "~/img/16.1.jpg", null },
                    { 27, 16, "~/img/16.2.jpg", null },
                    { 28, 17, "~/img/17.1.jpg", null },
                    { 29, 18, "~/img/18.1.jpg", null },
                    { 30, 19, "~/img/19.1.jpg", null },
                    { 31, 20, "~/img/20.1.jpg", null },
                    { 32, 21, "~/img/21.1.jpg", null },
                    { 33, 22, "~/img/22.1.jpg", null },
                    { 34, 23, "~/img/23.1.jpg", null },
                    { 35, 23, "~/img/23.2.jpg", null },
                    { 36, 24, "~/img/24.1.jpg", null },
                    { 37, 24, "~/img/24.2.jpg", null },
                    { 38, 25, "~/img/25.1.jpg", null },
                    { 39, 25, "~/img/25.2.jpg", null },
                    { 40, 26, "~/img/26.1.jpg", null },
                    { 41, 27, "~/img/27.1.jpg", null },
                    { 42, 28, "~/img/28.1.jpg", null },
                    { 43, 29, "~/img/29.1.jpg", null },
                    { 44, 30, "~/img/30.1.jpg", null },
                    { 45, 31, "~/img/31.1.jpg", null },
                    { 46, 31, "~/img/31.2.jpg", null },
                    { 47, 32, "~/img/32.1.jpg", null },
                    { 48, 33, "~/img/33.1.jpg", null },
                    { 49, 33, "~/img/33.2.jpg", null },
                    { 50, 34, "~/img/34.1.jpg", null },
                    { 51, 34, "~/img/34.2.jpg", null },
                    { 52, 35, "~/img/35.1.jpg", null },
                    { 53, 36, "~/img/36.1.jpg", null },
                    { 54, 36, "~/img/36.2.jpg", null },
                    { 55, 37, "~/img/37.1.jpg", null },
                    { 56, 37, "~/img/37.2.jpg", null },
                    { 57, 38, "~/img/38.1.jpg", null },
                    { 58, 39, "~/img/39.1.jpg", null },
                    { 59, 40, "~/img/40.1.jpg", null },
                    { 60, 41, "~/img/41.1.jpg", null },
                    { 61, 42, "~/img/42.1.jpg", null },
                    { 62, 42, "~/img/42.2.jpg", null },
                    { 63, 43, "~/img/43.1.jpg", null },
                    { 64, 44, "~/img/44.1.jpg", null },
                    { 65, 45, "~/img/45.1.jpg", null },
                    { 66, 46, "~/img/46.1.jpg", null },
                    { 67, 47, "~/img/47.1.jpg", null },
                    { 68, 47, "~/img/47.2.jpg", null },
                    { 69, 48, "~/img/48.1.jpg", null },
                    { 70, 48, "~/img/48.2.jpg", null },
                    { 71, 49, "~/img/49.1.jpg", null },
                    { 72, 49, "~/img/49.2.jpg", null },
                    { 73, 50, "~/img/50.1.jpg", null },
                    { 74, 50, "~/img/50.2.jpg", null },
                    { 75, 51, "~/img/51.1.jpg", null },
                    { 76, 52, "~/img/52.1.jpg", null },
                    { 77, 53, "~/img/53.1.jpg", null },
                    { 78, 54, "~/img/54.1.jpg", null },
                    { 79, 55, "~/img/55.1.jpg", null },
                    { 80, 56, "~/img/56.1.jpg", null },
                    { 81, 56, "~/img/56.2.jpg", null },
                    { 82, 57, "~/img/57.1.jpg", null },
                    { 83, 57, "~/img/57.2.jpg", null },
                    { 84, 58, "~/img/58.1.jpg", null },
                    { 85, 58, "~/img/58.2.jpg", null },
                    { 86, 59, "~/img/58.1.jpg", null },
                    { 87, 60, "~/img/60.1.jpg", null },
                    { 88, 12, "~/img/12.1.jpg", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 9, 12 });

            migrationBuilder.DeleteData(
                table: "CategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 9, 44 });

            migrationBuilder.DeleteData(
                table: "CategoryFoods",
                keyColumns: new[] { "CategoryId", "FoodId" },
                keyValues: new object[] { 9, 52 });

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 88);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Photos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(4716));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Infos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(4970),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 20, 22, 59, 183, DateTimeKind.Utc).AddTicks(2144));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(9330));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 13, 43, 48, 113, DateTimeKind.Utc).AddTicks(4742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 20, 22, 59, 182, DateTimeKind.Utc).AddTicks(4093));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 13, 43, 48, 111, DateTimeKind.Utc).AddTicks(6088),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 20, 22, 59, 180, DateTimeKind.Utc).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 111, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 111, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 111, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 111, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 111, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 111, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 111, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 111, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 111, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "CookingTime", "CreateTime", "HowManyPerson", "Materials", "Name", "PreparationTime", "RecipeExplanation" },
                values: new object[] { null, new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123), null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 39,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 40,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 41,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 42,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 43,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "CookingTime", "CreateTime", "HowManyPerson", "Materials", "Name", "PreparationTime", "RecipeExplanation" },
                values: new object[] { null, new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123), null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 45,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 46,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 47,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 48,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 49,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 50,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 51,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "CookingTime", "CreateTime", "HowManyPerson", "Materials", "Name", "PreparationTime", "RecipeExplanation" },
                values: new object[] { null, new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123), null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 53,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 54,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 55,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 56,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 57,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 58,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 59,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 60,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Infos",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "ID", "FoodId", "PhotoPath", "UserId" },
                values: new object[] { 20, 10, "~/img/10.2.jpg", null });
        }
    }
}
