using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Recipe.Entities.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 7, 21, 11, 30, 50, 548, DateTimeKind.Utc).AddTicks(8793))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Materials = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Like = table.Column<int>(type: "int", maxLength: 50, nullable: true),
                    HowManyPerson = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PreparationTime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CookingTime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PictureOne = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecipeExplanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(4176))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Myusers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoId = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Myusers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CategoryFoods",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryFoods", x => new { x.CategoryId, x.FoodId });
                    table.ForeignKey(
                        name: "FK_CategoryFoods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryFoods_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Stars = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 7, 21, 11, 30, 50, 549, DateTimeKind.Utc).AddTicks(9327))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.ID);
                    table.CheckConstraint("Stars", "[Stars]>=0 AND [Stars]<=5");
                    table.ForeignKey(
                        name: "FK_Comments_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 7, 21, 11, 30, 50, 550, DateTimeKind.Utc).AddTicks(7099))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Photos_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Photos_Myusers_UserId",
                        column: x => x.UserId,
                        principalTable: "Myusers",
                        principalColumn: "ID");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "ID", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Bakliyat Yemekleri" },
                    { 2, "Çorba Tarifleri" },
                    { 3, "Dolma-Sarma Tarifleri" },
                    { 4, "Et Yemekleri" },
                    { 5, "Hamur İşi Tarifleri" },
                    { 6, "Kahvaltılık Tarifleri" },
                    { 7, "Makarna Tarifleri" },
                    { 8, "Sebze Yemekleri" },
                    { 9, "Tatlı Tarifleri" }
                });

            migrationBuilder.InsertData(
                table: "Foods",
                columns: new[] { "ID", "CookingTime", "HowManyPerson", "Like", "Materials", "Name", "PictureOne", "PreparationTime", "RecipeExplanation" },
                values: new object[,]
                {
                    { 1, "20 dakika", "4 kişilik", null, "Yoğurt, un, yumurta, su, tuz, nane, tereyağı", "Yayla Çorbası", null, "10 dakika", "Yoğurt, un ve yumurtayı karıştırın. Suyu ekleyip pişirin, tereyağında nane kavurup çorbaya ekleyin." },
                    { 2, "35 dakika", "4 kişilik", null, "Kırmızı mercimek, bulgur, pirinç, soğan, domates salçası, biber salçası, su, tuz, nane, tereyağı", "Ezogelin Çorbası", null, "15 dakika", "Mercimek, bulgur ve pirinci haşlayın. Soğanı kavurun, salçaları ekleyin ve haşlanmış malzemelerle karıştırın." },
                    { 3, "30 dakika", "4 kişilik", null, "Kırmızı mercimek, soğan, havuç, patates, su, tuz, karabiber, tereyağı", "Mercimek Çorbası", null, "10 dakika", "Mercimekleri, soğanı, havucu ve patatesi haşlayın, blenderdan geçirin ve tereyağında kavurun." },
                    { 4, "20 dakika", "4 kişilik", null, "Tarhana, su, domates salçası, biber salçası, tereyağı, tuz", "Tarhana Çorbası", null, "5 dakika", "Tarhanayı suda çözün. Salçaları tereyağında kavurun ve tarhanayı ekleyip pişirin." },
                    { 5, "25 dakika", "4 kişilik", null, "Domates, un, tereyağı, su, süt, tuz, karabiber", "Domates Çorbası", null, "10 dakika", "Domatesleri rendeleyin. Un ve tereyağını kavurun, domatesleri ekleyin. Suyu ekleyip pişirin ve sütü ekleyin." },
                    { 6, "30 dakika", "4 kişilik", null, "Mantar, soğan, un, tereyağı, su, süt, tuz, karabiber", "Mantar Çorbası", null, "10 dakika", "Soğanı kavurun, mantarları ekleyin. Un ekleyip kavurun, su ve sütü ekleyip pişirin." },
                    { 7, "40 dakika", "4 kişilik", null, "Tavuk göğsü, su, havuç, patates, kereviz, tuz, karabiber", "Tavuk Suyu Çorbası", null, "10 dakika", "Tavuğu ve sebzeleri haşlayın, dIDikleyin ve suyu ile karıştırıp pişirin." },
                    { 8, "25 dakika", "4 kişilik", null, "Patates, havuç, kabak, kereviz, soğan, su, tuz, karabiber", "Sebze Çorbası", null, "15 dakika", "Sebzeleri doğrayın, haşlayın ve blenderdan geçirip pişirin." },
                    { 9, "20 dakika", "4 kişilik", null, "Tavuk suyu, arpa şehriye, domates salçası, tereyağı, su, tuz, karabiber", "Şehriye Çorbası", null, "5 dakika", "Tereyağında salçayı kavurun. Tavuk suyu ve su ekleyip kaynatın, şehriyeleri ekleyip pişirin." },
                    { 10, "30 dakika", "4 kişilik", null, "Balkabağı, soğan, patates, krema, su, tuz, karabiber, zeytinyağı", "Kremalı Balkabağı Çorbası", null, "10 dakika", "Soğanı kavurun, balkabağı ve patatesi ekleyin. Suyu ekleyip haşlayın, blenderdan geçirin ve krema ekleyin." },
                    { 11, "60+ dakika", "4 kişilik", null, "Nohut, soğan, domates, biber, zeytinyağı, tuz, karabiber", "Nohut Yemeği", null, "15 dakika", "Nohutları haşlayın, soğan ve biberi kavurun, domatesleri ekleyin. Haşlanmış nohutları ekleyin ve pişirin." },
                    { 12, null, null, null, null, null, null, null, null },
                    { 13, "30 dakika", "4 kişilik", null, "Bezelye, patates, havuç, soğan, zeytinyağı, tuz, karabiber", "Bezelye Yemeği", null, "10 dakika", "Soğanı kavurun, patates ve havucu ekleyin. Bezelyeleri ve suyu ekleyip pişirin." },
                    { 14, "60+ dakika", "4 kişilik", null, "Fasulye, soğan, domates, havuç, zeytinyağı, tuz, şeker", "Fasulye Pilaki", null, "15 dakika", "Fasulyeleri haşlayın, soğan ve havucu kavurun. Domatesleri ekleyip fasulyeleri ekleyin ve pişirin." },
                    { 15, "60+ dakika", "4 kişilik", null, "Kuru fasulye, soğan, domates, biber, zeytinyağı, tuz, karabiber", "Kuru Fasulye", null, "15 dakika", "Kuru fasulyeleri haşlayın, soğan ve biberi kavurun. Domatesleri ekleyip fasulyeleri ekleyin ve pişirin." },
                    { 16, "30 dakika", "4 kişilik", null, "Pirinç, nohut, soğan, zeytinyağı, tuz, karabiber", "Nohutlu Pilav", null, "10 dakika", "Nohutları haşlayın, soğanı kavurun. Pirinci ekleyin ve pişirin, nohutları ekleyin." },
                    { 17, "45 dakika", "4 kişilik", null, "Yeşil mercimek, soğan, domates, havuç, zeytinyağı, tuz, karabiber", "Yeşil Mercimek Yemeği", null, "15 dakika", "Soğanı kavurun, havuç ve domatesi ekleyin. Mercimekleri ekleyip pişirin." },
                    { 18, "30 dakika", "4 kişilik", null, "Bezelye, patates, soğan, zeytinyağı, tuz, karabiber", "Patatesli Bezelye", null, "10 dakika", "Soğanı kavurun, patates ve bezelyeyi ekleyin. Su ekleyip pişirin." },
                    { 19, "20 dakika", "4 kişilik", null, "Bulgur, domates, salatalık, yeşil soğan, nar ekşisi, zeytinyağı, tuz, karabiber", "Kısır", null, "10 dakika", "Bulguru sıcak suyla ıslatın, domates, salatalık ve yeşil soğanı doğrayın. Karıştırın ve baharatları ekleyin." },
                    { 20, "60+ dakika", "4 kişilik", null, "Kuru fasulye, pirinç, soğan, domates, biber, zeytinyağı, tuz", "Kuru Fasulye Pilav", null, "15 dakika", "Kuru fasulyeleri haşlayın, pirinci hazırlayın. Fasulyeleri ve pilavı servis edin." },
                    { 21, "60+ dakika", "4 kişilik", null, "Biber, pirinç, kıyma, soğan, domates, zeytinyağı, tuz, karabiber, nane", "Dolma", null, "20 dakika", "Kıymayı soğanla kavurun, pirinci ve baharatları ekleyin. Biberleri doldurup pişirin." },
                    { 22, "45 dakika", "4 kişilik", null, "Asma yaprağı, pirinç, kıyma, soğan, domates, zeytinyağı, tuz, karabiber, nane", "Zeytinyağlı Sarma", null, "30 dakika", "Pirinci, kıymayı ve baharatları karıştırın. Asma yapraklarına sarıp, zeytinyağı ile pişirin." },
                    { 23, "60+ dakika", "4 kişilik", null, "Lahana, pirinç, kıyma, soğan, domates, zeytinyağı, tuz, karabiber, nane", "Lahana Sarma", null, "30 dakika", "Kıymayı soğanla kavurun, pirinci ve baharatları ekleyin. Lahana yapraklarına sarıp pişirin." },
                    { 24, "60+ dakika", "4 kişilik", null, "Patlıcan, kıyma, pirinç, soğan, domates, zeytinyağı, tuz, karabiber, nane", "Patlıcan Dolması", null, "25 dakika", "Kıymayı soğanla kavurun, pirinci ve baharatları ekleyin. Patlıcanları doldurup pişirin." },
                    { 25, "60+ dakika", "4 kişilik", null, "Kabak, kıyma, pirinç, soğan, domates, zeytinyağı, tuz, karabiber, nane", "Kabak Dolması", null, "20 dakika", "Kıymayı soğanla kavurun, pirinci ve baharatları ekleyin. Kabakları doldurup pişirin." },
                    { 26, "10 dakika", "4 kişilik", null, "Kısır, biber, domates, salatalık, nar ekşisi, zeytinyağı, tuz, karabiber", "Kısır Dolması", null, "20 dakika", "Kısırı hazırlayıp biberlerin içine doldurun. Domates ve salatalık ile servis edin." },
                    { 27, "45 dakika", "4 kişilik", null, "Dana eti, yoğurt, domates sosu, pilav, biber, tuz, karabiber", "İskender Dolması", null, "30 dakika", "Dana etini pişirin, biberleri doldurun ve yoğurt ile domates sosunu ekleyip pişirin." },
                    { 28, "10 dakika", "4 kişilik", null, "Kısır, marul yaprağı, domates, salatalık, nar ekşisi, zeytinyağı, tuz", "Kısır Sarma", null, "15 dakika", "Kısırı marul yapraklarına sarın, domates ve salatalık ile servis edin." },
                    { 29, "60+ dakika", "4 kişilik", null, "Patlıcan, biber, domates, kıyma, pirinç, soğan, zeytinyağı, tuz, karabiber", "Fırın Dolması", null, "30 dakika", "Patlıcan ve biberleri doldurun, domatesle kaplayıp fırında pişirin." },
                    { 30, "60+ dakika", "4 kişilik", null, "Lahana yaprağı, pirinç, kıyma, soğan, domates, zeytinyağı, tuz, karabiber", "Zeytinyağlı Lahana Sarma", null, "30 dakika", "Pirinci ve kıymayı karıştırın, lahana yapraklarına sarın ve zeytinyağı ile pişirin." },
                    { 31, "2 saat", "4 kişilik", null, "Kuzu eti, soğan, sarımsak, zeytinyağı, tuz, karabiber, kekik", "Kuzu Tandır", null, "20 dakika", "Kuzu etini soğan ve sarımsakla birlikte zeytinyağında kavurun. Baharatları ekleyip fırında pişirin." },
                    { 32, "15 dakika", "2 kişilik", null, "Biftek, tuz, karabiber, tereyağı, sarımsak, kekik", "Biftek", null, "10 dakika", "Bifteği tuz ve karabiberle tatlandırın. Tereyağında ve sarımsakla birlikte kızartın. Kekik serpin." },
                    { 33, "20 dakika", "4 kişilik", null, "Kıyma, soğan, ekmek içi, yumurta, tuz, karabiber, kimyon, pul biber", "Köfte", null, "20 dakika", "Kıymayı, soğanı ve baharatları yoğurun. Köfte şekli verip ızgarada pişirin." },
                    { 34, "60+ dakika", "4 kişilik", null, "Dana eti, nohut, soğan, domates, biber, zeytinyağı, tuz, karabiber", "Etli Nohut Yemeği", null, "15 dakika", "Etleri kavurun, soğan ve biberi ekleyin. Domates ve nohutları ilave edip pişirin." },
                    { 35, "40 dakika", "4 kişilik", null, "Dana eti, pirinç, soğan, tereyağı, tuz, karabiber, baharatlar", "Etli Pirinç Pilavı", null, "15 dakika", "Etleri soğanla kavurun, pirinci ekleyin ve pişirin. Baharatları ekleyip servis yapın." },
                    { 36, "30 dakika", "6 kişilik", null, "Yufka, beyaz peynir, lor peyniri, maydanoz, zeytinyağı, tuz, karabiber", "Peynirli Börek", null, "20 dakika", "Yufkaları kat kat serin, peynir ve maydanoz karışımını aralarına koyun. Fırında pişirin." },
                    { 37, "20 dakika", "4 kişilik", null, "Yufka, beyaz peynir, maydanoz, zeytinyağı, tuz, karabiber", "Sigara Böreği", null, "15 dakika", "Yufkayı dilimleyip peynirli karışımı koyun, sigara şeklinde sarıp kızartın." },
                    { 38, "60+ dakika", "8 kişilik", null, "Un, su, maya, tuz, şeker", "Köy Ekmek", null, "20 dakika", "Un, su, maya, tuz ve şekeri yoğurun. Hamuru mayalandırıp fırında pişirin." },
                    { 39, "25 dakika", "4 kişilik", null, "Pizza hamuru, domates sosu, mozzarella peyniri, sucuk, zeytin, mantar, zeytinyağı", "Pizza", null, "20 dakika", "Hamuru açıp üzerine sos ve malzemeleri ekleyin. Fırında pişirin." },
                    { 40, "25 dakika", "12 kişilik", null, "Un, süt, yumurta, margarin, maya, tuz, beyaz peynir", "Poğaça", null, "20 dakika", "Hamuru yoğurun ve mayalandırın. Peynirli harcı koyup şekil verin, fırında pişirin." },
                    { 41, "15 dakika", "4 kişilik", null, "Domates, yeşil biber, yumurta, zeytinyağı, tuz, karabiber", "Menemen", null, "10 dakika", "Biberleri ve domatesleri zeytinyağında kavurun, yumurtaları ekleyip karıştırarak pişirin." },
                    { 42, "10 dakika", "2 kişilik", null, "Yumurta, tereyağı, tuz, karabiber", "Sahanda Yumurta", null, "5 dakika", "Tereyağında yumurtaları kırıp pişirin. Tuz ve karabiberle tatlandırın." },
                    { 43, "0 dakika", "4 kişilik", null, "Çeşitli peynirler (beyaz peynir, kaşar, lor), zeytin, domates, salatalık, zeytinyağı", "Kahvaltılık Peynir Tabağı", null, "10 dakika", "Peynirleri dilimleyip tabağa yerleştirin. Zeytin, domates ve salatalık ekleyin." },
                    { 44, null, null, null, null, null, null, null, null },
                    { 45, "10 dakika", "2 kişilik", null, "Sosis, yumurta, tereyağı, tuz, karabiber", "Yumurtalı Sosis", null, "5 dakika", "Sosisleri tereyağında kızartın. Üzerine yumurtayı kırıp pişirin, tuz ve karabiberle tatlandırın." },
                    { 46, "20 dakika", "4 kişilik", null, "Spaghetti, yumurta, parmesan peyniri, pastırma, sarımsak, zeytinyağı, tuz, karabiber", "Spaghetti Carbonara", null, "15 dakika", "Spaghettiyi haşlayın. Pastırmayı ve sarımsağı zeytinyağında kavurun, yumurta ve peynir karışımını ekleyin. Spaghettiyi karışıma ekleyip karıştırın." },
                    { 47, "15 dakika", "4 kişilik", null, "Fettucine, tereyağı, krema, parmesan peyniri, sarımsak, tuz, karabiber", "Fettucine Alfredo", null, "10 dakika", "Fettucineyi haşlayın. Tereyağını eritip kremayı ekleyin, peynirle karıştırın. Sosu makarnaya döküp karıştırın." },
                    { 48, "20 dakika", "4 kişilik", null, "Penne, domates sosu, kırmızı biber, sarımsak, zeytinyağı, tuz, karabiber, maydanoz", "Penne Arrabbiata", null, "10 dakika", "Penneyi haşlayın. Sarımsağı ve kırmızı biberi zeytinyağında kavurun, domates sosunu ekleyin. Sosu makarnaya döküp maydanoz ile süsleyin." },
                    { 49, "30 dakika", "4 kişilik", null, "Makarna, cheddar peyniri, süt, tereyağı, un, tuz, karabiber, muskat cevizi", "Mac and Cheese", null, "10 dakika", "Makarna haşlanır. Sos için tereyağı ve unu kavurun, süt ekleyip koyulaşana kadar pişirin. Peynirleri ekleyip eritin. Sosu makarnaya dökün, fırında 15 dakika pişirin." },
                    { 50, "45 dakika", "4 kişilik", null, "Makarna, kıyma, domates sosu, soğan, sarımsak, havuç, kereviz, zeytinyağı, tuz, karabiber, kekik", "Bolognese Soslu Makarna", null, "15 dakika", "Kıymayı soğan, sarımsak, havuç ve kereviz ile kavurun. Domates sosunu ekleyip kısık ateşte pişirin. Makarnayı haşlayıp sosla karıştırın." },
                    { 51, "40 dakika", "4 kişilik", null, "Enginar, zeytinyağı, limon, soğan, havuç, bezelye, tuz, karabiber, dereotu", "Zeytinyağlı Enginar", null, "20 dakika", "Enginarları limonlu suya bekletin. Soğanı ve havucu zeytinyağında kavurun. Enginarları ekleyip bezelye ve su ilave edin. Piştikten sonra dereotu ile süsleyin." },
                    { 52, null, null, null, null, null, null, null, null },
                    { 53, "30 dakika", "4 kişilik", null, "Patates, soğan, domates, biber, zeytinyağı, tuz, karabiber, pul biber", "Patates Yemeği", null, "15 dakika", "Patatesleri ve soğanları doğrayıp zeytinyağında kavurun. Domates ve biberleri ekleyin, baharatlarla tatlandırın. Kısık ateşte pişirin." },
                    { 54, "25 dakika", "4 kişilik", null, "Kabak, zeytinyağı, sarımsak, tuz, karabiber, kekik, parmesan peyniri", "Fırında Kabak", null, "10 dakika", "Kabları dilimleyip zeytinyağı, sarımsak ve baharatlarla harmanlayın. Fırın tepsisine dizip parmesan peyniri serpin, fırında pişirin." },
                    { 55, "20 dakika", "4 kişilik", null, "Karnabahar, un, yumurta, tuz, karabiber, sıvı yağ", "Karnabahar Kızartması", null, "15 dakika", "Karnabaharları çiçeklerine ayırın. Un ve yumurtaya bulayıp sıvı yağda kızartın. Tuz ve karabiber ile tatlandırın." },
                    { 56, "45 dakika", "4 kişilik", null, "Pirinç, süt, şeker, vanilin, su, tarçın", "Sütlaç", null, "10 dakika", "Pirinçleri suyla haşlayın. Sütü ve şekeri ekleyip karıştırarak pişirin. Vanilini ekleyip karıştırın. Kaselere döküp soğutun, tarçın serpin." },
                    { 57, "45 dakika", "8 kişilik", null, "Yufka, ceviz, tereyağı, şeker, su, limon suyu", "Baklava", null, "30 dakika", "Yufkaları tereyağı ile yağlayarak üst üste koyun. Cevizi serpin ve dilimleyin. Fırında pişirip şerbet dökün." },
                    { 58, "60+ dakika", "4 kişilik", null, "Patates, tereyağı, kaşar peyniri, zeytin, mısır, sosis, mayonez, ketçap, tuz", "Kumpir", null, "15 dakika", "Patatesleri fırında pişirin. Kumpirleri kesip içlerini tereyağı ve kaşar ile karıştırın. Üzerine zeytin, mısır, sosis ve sosları ekleyin." },
                    { 59, "30 dakika", "8 kişilik", null, "Yumurta, şeker, un, irmik, yoğurt, kabartma tozu, limon suyu, şeker", "Revani", null, "15 dakika", "Yumurta ve şekeri çırpın, diğer malzemeleri ekleyip karıştırın. Fırında pişirin ve soğuduktan sonra şerbet dökün." },
                    { 60, "20 dakika", "4 kişilik", null, "Süt, şeker, kakao, nişasta, vanilin", "Puding", null, "10 dakika", "Süt, şeker ve kakao karışımını kaynatın. Nişasta ve vanilini ekleyip karıştırarak pişirin. Kaselere döküp soğutun." }
                });

            migrationBuilder.InsertData(
                table: "CategoryFoods",
                columns: new[] { "CategoryId", "FoodId" },
                values: new object[,]
                {
                    { 1, 11 },
                    { 1, 13 },
                    { 1, 14 },
                    { 1, 15 },
                    { 1, 16 },
                    { 1, 17 },
                    { 1, 18 },
                    { 1, 19 },
                    { 1, 20 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 3, 21 },
                    { 3, 22 },
                    { 3, 23 },
                    { 3, 24 },
                    { 3, 25 },
                    { 3, 26 },
                    { 3, 27 },
                    { 3, 28 },
                    { 3, 29 },
                    { 3, 30 },
                    { 4, 31 },
                    { 4, 32 },
                    { 4, 33 },
                    { 4, 34 },
                    { 4, 35 },
                    { 5, 36 },
                    { 5, 37 },
                    { 5, 38 },
                    { 5, 39 },
                    { 5, 40 },
                    { 6, 19 },
                    { 6, 41 },
                    { 6, 42 },
                    { 6, 43 },
                    { 6, 45 },
                    { 7, 46 },
                    { 7, 47 },
                    { 7, 48 },
                    { 7, 49 },
                    { 7, 50 },
                    { 8, 19 },
                    { 8, 51 },
                    { 8, 53 },
                    { 8, 54 },
                    { 8, 55 },
                    { 9, 56 },
                    { 9, 57 },
                    { 9, 58 },
                    { 9, 59 },
                    { 9, 60 }
                });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "ID", "FoodId", "PhotoPath", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "~/img/1.1.jpg", null },
                    { 2, 1, "~/img/1.2.jpg", null },
                    { 3, 2, "~/img/2.1.jpg", null },
                    { 4, 2, "~/img/2.2.jpg", null },
                    { 5, 3, "~/img/3.1.jpg", null },
                    { 6, 3, "~/img/3.2.jpg", null },
                    { 7, 4, "~/img/4.1.jpg", null },
                    { 8, 4, "~/img/4.2.jpg", null },
                    { 9, 5, "~/img/5.1.jpg", null },
                    { 10, 5, "~/img/5.2.jpg", null },
                    { 11, 6, "~/img/6.1.jpg", null },
                    { 12, 6, "~/img/6.2.jpg", null },
                    { 13, 7, "~/img/7.1.jpg", null },
                    { 14, 7, "~/img/7.2.jpg", null },
                    { 15, 8, "~/img/8.1.jpg", null },
                    { 16, 8, "~/img/8.2.jpg", null },
                    { 17, 9, "~/img/9.1.jpg", null },
                    { 18, 9, "~/img/9.2.jpg", null },
                    { 19, 10, "~/img/10.1.jpg", null },
                    { 20, 10, "~/img/10.2.jpg", null },
                    { 21, 11, "~/img/11.1.jpg", null },
                    { 22, 13, "~/img/13.1.jpg", null },
                    { 23, 14, "~/img/14.1.jpg", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryName",
                table: "Categories",
                column: "CategoryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ID",
                table: "Categories",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryFoods_FoodId",
                table: "CategoryFoods",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_FoodId",
                table: "Comments",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ID",
                table: "Comments",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_ID",
                table: "Foods",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_FoodId",
                table: "Photos",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_ID",
                table: "Photos",
                column: "ID");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_UserId",
                table: "Photos",
                column: "UserId",
                unique: true,
                filter: "[UserId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CategoryFoods");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Myusers");
        }
    }
}
