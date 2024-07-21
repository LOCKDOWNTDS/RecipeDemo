using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Recipe.Entities.Migrations
{
    /// <inheritdoc />
    public partial class info : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Photos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 13, 43, 48, 113, DateTimeKind.Utc).AddTicks(4742),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 11, 30, 50, 549, DateTimeKind.Utc).AddTicks(9327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 13, 43, 48, 111, DateTimeKind.Utc).AddTicks(6088),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 11, 30, 50, 548, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.CreateTable(
                name: "Infos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    inf = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(4970))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Infos", x => x.ID);
                });

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
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

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
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

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
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

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

            migrationBuilder.InsertData(
                table: "Infos",
                columns: new[] { "ID", "inf" },
                values: new object[,]
                {
                    { 1, "Yemeklerin lezzeti büyük ölçüde kullanılan malzemelerin kalitesine bağlıdır. Taze ve kaliteli malzemeler kullanmaya özen gösterin." },
                    { 2, "Tarife sadık kalmak, doğru miktarda malzeme kullanmak önemlidir. Özellikle tuz, baharat ve şeker gibi tatları dikkatlice ölçün." },
                    { 3, "Yemek yapmaya başlamadan önce tüm malzemeleri hazırlayın. Bu, yemek yapma sürecini daha düzenli ve hızlı hale getirir." },
                    { 4, "Pişirme sırasında ısıyı doğru ayarlamak önemlidir. Kısık ateşte pişirilen yemekler genellikle daha lezzetli ve dengeli olur." },
                    { 5, "Baharatları yemeklerin pişirme sürecinin başında değil, genellikle sonlarına doğru eklemek, baharatların aromasını kaybetmesini engeller." },
                    { 6, "Pişirdiğiniz yemekleri servisten önce bir süre dinlendirmek, lezzetlerin birbirine karışmasına ve yemeklerin daha iyi bir tat profilinin oluşmasına yardımcı olur." },
                    { 7, "Yemekleri gereğinden fazla pişirmek lezzetlerini kaybettirebilir. Tarife göre önerilen süreleri dikkate alın ve pişirme süresini kontrol edin." },
                    { 8, "Yemeklerde tuz ve şeker miktarını dengelemek önemlidir. Tatları dengede tutmak için küçük miktarlarda ekleyin ve tadına bakarak ayarlayın." },
                    { 9, "Sosları yemeklerin üzerine dökmeden önce, sosun kıvamını ve tadını kontrol edin. Sosları yemekle aynı anda pişirmek, daha iyi bir uyum sağlar." },
                    { 10, "Yemeklerin sunumu da en az lezzeti kadar önemlidir. Güzel bir sunum, yemeklerin tadını daha da artırabilir ve iştah açıcı hale getirebilir." }
                });

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
                keyValue: 20,
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

            migrationBuilder.CreateIndex(
                name: "IX_Infos_ID",
                table: "Infos",
                column: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Infos");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Photos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(7175));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Foods",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 13, 43, 48, 114, DateTimeKind.Utc).AddTicks(2123));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Comments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 11, 30, 50, 549, DateTimeKind.Utc).AddTicks(9327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 13, 43, 48, 113, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateTime",
                table: "Categories",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 21, 11, 30, 50, 548, DateTimeKind.Utc).AddTicks(8793),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 21, 13, 43, 48, 111, DateTimeKind.Utc).AddTicks(6088));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 548, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 548, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 548, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 548, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 548, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 548, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 548, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 548, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 548, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 24,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 25,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 26,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 27,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 28,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 29,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 30,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 31,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 32,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 33,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 34,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 35,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 36,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 37,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 38,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 39,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 40,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 41,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 42,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 43,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 44,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 45,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 46,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 47,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 48,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 49,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 50,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 51,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 52,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 53,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 54,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 55,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 56,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 57,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 58,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 59,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Foods",
                keyColumn: "ID",
                keyValue: 60,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 20,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 21,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 22,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Photos",
                keyColumn: "ID",
                keyValue: 23,
                column: "CreateTime",
                value: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099));
        }
    }
}
