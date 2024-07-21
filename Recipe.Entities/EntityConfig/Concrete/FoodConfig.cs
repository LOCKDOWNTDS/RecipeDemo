using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipe.Entities.EntityConfig.Abstract;
using Recipe.Entities.Model.Concrete;

namespace Recipe.Entities.EntityConfig.Concrete
{
    public class FoodConfig : BaseConfig<Food, int>
    {
        public override void Configure(EntityTypeBuilder<Food> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name).HasMaxLength(50);
            builder.Property(p => p.Materials).HasMaxLength(500);
            builder.Property(p => p.Like).HasMaxLength(50);
            builder.Property(p => p.CookingTime).HasMaxLength(50);
            builder.Property(p => p.PreparationTime).HasMaxLength(50);
            builder.Property(p => p.HowManyPerson).HasMaxLength(50);
            builder.HasData(

                new Food
                {
                    ID = 3,
                    Name = "Mercimek Çorbası",
                    Materials = "Kırmızı mercimek, soğan, havuç, patates, su, tuz, karabiber, tereyağı",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "10 dakika",
                    CookingTime = "30 dakika",
                    RecipeExplanation = "Mercimekleri, soğanı, havucu ve patatesi haşlayın, blenderdan geçirin ve tereyağında kavurun.",

                },
                new Food
                {
                    ID = 2,
                    Name = "Ezogelin Çorbası",
                    Materials = "Kırmızı mercimek, bulgur, pirinç, soğan, domates salçası, biber salçası, su, tuz, nane, tereyağı",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "15 dakika",
                    CookingTime = "35 dakika",
                    RecipeExplanation = "Mercimek, bulgur ve pirinci haşlayın. Soğanı kavurun, salçaları ekleyin ve haşlanmış malzemelerle karıştırın."
                },
                new Food
                {
                    ID = 1,
                    Name = "Yayla Çorbası",
                    Materials = "Yoğurt, un, yumurta, su, tuz, nane, tereyağı",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "10 dakika",
                    CookingTime = "20 dakika",
                    RecipeExplanation = "Yoğurt, un ve yumurtayı karıştırın. Suyu ekleyip pişirin, tereyağında nane kavurup çorbaya ekleyin."
                },
                new Food
                {
                    ID = 4,
                    Name = "Tarhana Çorbası",
                    Materials = "Tarhana, su, domates salçası, biber salçası, tereyağı, tuz",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "5 dakika",
                    CookingTime = "20 dakika",
                    RecipeExplanation = "Tarhanayı suda çözün. Salçaları tereyağında kavurun ve tarhanayı ekleyip pişirin."
                },
                new Food
                {
                    ID = 5,
                    Name = "Domates Çorbası",
                    Materials = "Domates, un, tereyağı, su, süt, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "10 dakika",
                    CookingTime = "25 dakika",
                    RecipeExplanation = "Domatesleri rendeleyin. Un ve tereyağını kavurun, domatesleri ekleyin. Suyu ekleyip pişirin ve sütü ekleyin."
                },
                new Food
                {
                    ID = 6,
                    Name = "Mantar Çorbası",
                    Materials = "Mantar, soğan, un, tereyağı, su, süt, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "10 dakika",
                    CookingTime = "30 dakika",
                    RecipeExplanation = "Soğanı kavurun, mantarları ekleyin. Un ekleyip kavurun, su ve sütü ekleyip pişirin."
                },
                new Food
                {
                    ID = 7,
                    Name = "Tavuk Suyu Çorbası",
                    Materials = "Tavuk göğsü, su, havuç, patates, kereviz, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "10 dakika",
                    CookingTime = "40 dakika",
                    RecipeExplanation = "Tavuğu ve sebzeleri haşlayın, dIDikleyin ve suyu ile karıştırıp pişirin."
                },
                new Food
                {
                    ID = 8,
                    Name = "Sebze Çorbası",
                    Materials = "Patates, havuç, kabak, kereviz, soğan, su, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "15 dakika",
                    CookingTime = "25 dakika",
                    RecipeExplanation = "Sebzeleri doğrayın, haşlayın ve blenderdan geçirip pişirin."
                },
                new Food
                {
                    ID = 9,
                    Name = "Şehriye Çorbası",
                    Materials = "Tavuk suyu, arpa şehriye, domates salçası, tereyağı, su, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "5 dakika",
                    CookingTime = "20 dakika",
                    RecipeExplanation = "Tereyağında salçayı kavurun. Tavuk suyu ve su ekleyip kaynatın, şehriyeleri ekleyip pişirin."
                },
                new Food
                {

                    ID = 10,
                    Name = "Kremalı Balkabağı Çorbası",
                    Materials = "Balkabağı, soğan, patates, krema, su, tuz, karabiber, zeytinyağı",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "10 dakika",
                    CookingTime = "30 dakika",
                    RecipeExplanation = "Soğanı kavurun, balkabağı ve patatesi ekleyin. Suyu ekleyip haşlayın, blenderdan geçirin ve krema ekleyin."
                },


                new Food
                {
                    ID = 11,
                    Name = "Nohut Yemeği",
                    Materials = "Nohut, soğan, domates, biber, zeytinyağı, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "15 dakika",
                    CookingTime = "60+ dakika",
                    RecipeExplanation = "Nohutları haşlayın, soğan ve biberi kavurun, domatesleri ekleyin. Haşlanmış nohutları ekleyin ve pişirin."
                },
                new Food
                {
                    ID = 12
                },
                new Food
                {
                    ID = 13,
                    Name = "Bezelye Yemeği",
                    Materials = "Bezelye, patates, havuç, soğan, zeytinyağı, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "10 dakika",
                    CookingTime = "30 dakika",
                    RecipeExplanation = "Soğanı kavurun, patates ve havucu ekleyin. Bezelyeleri ve suyu ekleyip pişirin."
                },
                new Food
                {
                    ID = 14,
                    Name = "Fasulye Pilaki",
                    Materials = "Fasulye, soğan, domates, havuç, zeytinyağı, tuz, şeker",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "15 dakika",
                    CookingTime = "60+ dakika",
                    RecipeExplanation = "Fasulyeleri haşlayın, soğan ve havucu kavurun. Domatesleri ekleyip fasulyeleri ekleyin ve pişirin."
                },
                new Food
                {
                    ID = 15,
                    Name = "Kuru Fasulye",
                    Materials = "Kuru fasulye, soğan, domates, biber, zeytinyağı, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "15 dakika",
                    CookingTime = "60+ dakika",
                    RecipeExplanation = "Kuru fasulyeleri haşlayın, soğan ve biberi kavurun. Domatesleri ekleyip fasulyeleri ekleyin ve pişirin."
                },
                new Food
                {
                    ID = 16,
                    Name = "Nohutlu Pilav",
                    Materials = "Pirinç, nohut, soğan, zeytinyağı, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "10 dakika",
                    CookingTime = "30 dakika",
                    RecipeExplanation = "Nohutları haşlayın, soğanı kavurun. Pirinci ekleyin ve pişirin, nohutları ekleyin."
                },
                new Food
                {
                    ID = 17,
                    Name = "Yeşil Mercimek Yemeği",
                    Materials = "Yeşil mercimek, soğan, domates, havuç, zeytinyağı, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "15 dakika",
                    CookingTime = "45 dakika",
                    RecipeExplanation = "Soğanı kavurun, havuç ve domatesi ekleyin. Mercimekleri ekleyip pişirin."
                },
                new Food
                {
                    ID = 18,
                    Name = "Patatesli Bezelye",
                    Materials = "Bezelye, patates, soğan, zeytinyağı, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "10 dakika",
                    CookingTime = "30 dakika",
                    RecipeExplanation = "Soğanı kavurun, patates ve bezelyeyi ekleyin. Su ekleyip pişirin."
                },
                new Food
                {
                    ID = 19,
                    Name = "Kısır",
                    Materials = "Bulgur, domates, salatalık, yeşil soğan, nar ekşisi, zeytinyağı, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "10 dakika",
                    CookingTime = "20 dakika",
                    RecipeExplanation = "Bulguru sıcak suyla ıslatın, domates, salatalık ve yeşil soğanı doğrayın. Karıştırın ve baharatları ekleyin."
                },
                new Food
                {
                    ID = 20,
                    Name = "Kuru Fasulye Pilav",
                    Materials = "Kuru fasulye, pirinç, soğan, domates, biber, zeytinyağı, tuz",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "15 dakika",
                    CookingTime = "60+ dakika",
                    RecipeExplanation = "Kuru fasulyeleri haşlayın, pirinci hazırlayın. Fasulyeleri ve pilavı servis edin."
                },

                new Food
                {
                    ID = 21,
                    Name = "Dolma",
                    Materials = "Biber, pirinç, kıyma, soğan, domates, zeytinyağı, tuz, karabiber, nane",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "20 dakika",
                    CookingTime = "60+ dakika",
                    RecipeExplanation = "Kıymayı soğanla kavurun, pirinci ve baharatları ekleyin. Biberleri doldurup pişirin."
                },
                new Food
                {
                    ID = 22,
                    Name = "Zeytinyağlı Sarma",
                    Materials = "Asma yaprağı, pirinç, kıyma, soğan, domates, zeytinyağı, tuz, karabiber, nane",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "30 dakika",
                    CookingTime = "45 dakika",
                    RecipeExplanation = "Pirinci, kıymayı ve baharatları karıştırın. Asma yapraklarına sarıp, zeytinyağı ile pişirin."
                },
                new Food
                {
                    ID = 23,
                    Name = "Lahana Sarma",
                    Materials = "Lahana, pirinç, kıyma, soğan, domates, zeytinyağı, tuz, karabiber, nane",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "30 dakika",
                    CookingTime = "60+ dakika",
                    RecipeExplanation = "Kıymayı soğanla kavurun, pirinci ve baharatları ekleyin. Lahana yapraklarına sarıp pişirin."
                },
                new Food
                {
                    ID = 24,
                    Name = "Patlıcan Dolması",
                    Materials = "Patlıcan, kıyma, pirinç, soğan, domates, zeytinyağı, tuz, karabiber, nane",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "25 dakika",
                    CookingTime = "60+ dakika",
                    RecipeExplanation = "Kıymayı soğanla kavurun, pirinci ve baharatları ekleyin. Patlıcanları doldurup pişirin."
                },
                new Food
                {
                    ID = 25,
                    Name = "Kabak Dolması",
                    Materials = "Kabak, kıyma, pirinç, soğan, domates, zeytinyağı, tuz, karabiber, nane",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "20 dakika",
                    CookingTime = "60+ dakika",
                    RecipeExplanation = "Kıymayı soğanla kavurun, pirinci ve baharatları ekleyin. Kabakları doldurup pişirin."
                },
                new Food
                {
                    ID = 26,
                    Name = "Kısır Dolması",
                    Materials = "Kısır, biber, domates, salatalık, nar ekşisi, zeytinyağı, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "20 dakika",
                    CookingTime = "10 dakika",
                    RecipeExplanation = "Kısırı hazırlayıp biberlerin içine doldurun. Domates ve salatalık ile servis edin."
                },
                new Food
                {
                    ID = 27,
                    Name = "İskender Dolması",
                    Materials = "Dana eti, yoğurt, domates sosu, pilav, biber, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "30 dakika",
                    CookingTime = "45 dakika",
                    RecipeExplanation = "Dana etini pişirin, biberleri doldurun ve yoğurt ile domates sosunu ekleyip pişirin."
                },
                new Food
                {
                    ID = 28,
                    Name = "Kısır Sarma",
                    Materials = "Kısır, marul yaprağı, domates, salatalık, nar ekşisi, zeytinyağı, tuz",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "15 dakika",
                    CookingTime = "10 dakika",
                    RecipeExplanation = "Kısırı marul yapraklarına sarın, domates ve salatalık ile servis edin."
                },
                new Food
                {
                    ID = 29,
                    Name = "Fırın Dolması",
                    Materials = "Patlıcan, biber, domates, kıyma, pirinç, soğan, zeytinyağı, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "30 dakika",
                    CookingTime = "60+ dakika",
                    RecipeExplanation = "Patlıcan ve biberleri doldurun, domatesle kaplayıp fırında pişirin."
                },
                new Food
                {
                    ID = 30,
                    Name = "Zeytinyağlı Lahana Sarma",
                    Materials = "Lahana yaprağı, pirinç, kıyma, soğan, domates, zeytinyağı, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "30 dakika",
                    CookingTime = "60+ dakika",
                    RecipeExplanation = "Pirinci ve kıymayı karıştırın, lahana yapraklarına sarın ve zeytinyağı ile pişirin."
                },

                new Food
                {
                    ID = 31,
                    Name = "Kuzu Tandır",
                    Materials = "Kuzu eti, soğan, sarımsak, zeytinyağı, tuz, karabiber, kekik",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "20 dakika",
                    CookingTime = "2 saat",
                    RecipeExplanation = "Kuzu etini soğan ve sarımsakla birlikte zeytinyağında kavurun. Baharatları ekleyip fırında pişirin."
                },
                new Food
                {
                    ID = 32,
                    Name = "Biftek",
                    Materials = "Biftek, tuz, karabiber, tereyağı, sarımsak, kekik",
                    HowManyPerson = "2 kişilik",
                    PreparationTime = "10 dakika",
                    CookingTime = "15 dakika",
                    RecipeExplanation = "Bifteği tuz ve karabiberle tatlandırın. Tereyağında ve sarımsakla birlikte kızartın. Kekik serpin."
                },
                new Food
                {
                    ID = 33,
                    Name = "Köfte",
                    Materials = "Kıyma, soğan, ekmek içi, yumurta, tuz, karabiber, kimyon, pul biber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "20 dakika",
                    CookingTime = "20 dakika",
                    RecipeExplanation = "Kıymayı, soğanı ve baharatları yoğurun. Köfte şekli verip ızgarada pişirin."
                },
                new Food
                {
                    ID = 34,
                    Name = "Etli Nohut Yemeği",
                    Materials = "Dana eti, nohut, soğan, domates, biber, zeytinyağı, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "15 dakika",
                    CookingTime = "60+ dakika",
                    RecipeExplanation = "Etleri kavurun, soğan ve biberi ekleyin. Domates ve nohutları ilave edip pişirin."
                },
                new Food
                {
                    ID = 35,
                    Name = "Etli Pirinç Pilavı",
                    Materials = "Dana eti, pirinç, soğan, tereyağı, tuz, karabiber, baharatlar",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "15 dakika",
                    CookingTime = "40 dakika",
                    RecipeExplanation = "Etleri soğanla kavurun, pirinci ekleyin ve pişirin. Baharatları ekleyip servis yapın."
                },

                new Food
                {
                    ID = 36,
                    Name = "Peynirli Börek",
                    Materials = "Yufka, beyaz peynir, lor peyniri, maydanoz, zeytinyağı, tuz, karabiber",
                    HowManyPerson = "6 kişilik",
                    PreparationTime = "20 dakika",
                    CookingTime = "30 dakika",
                    RecipeExplanation = "Yufkaları kat kat serin, peynir ve maydanoz karışımını aralarına koyun. Fırında pişirin."
                },
                new Food
                {
                    ID = 37,
                    Name = "Sigara Böreği",
                    Materials = "Yufka, beyaz peynir, maydanoz, zeytinyağı, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "15 dakika",
                    CookingTime = "20 dakika",
                    RecipeExplanation = "Yufkayı dilimleyip peynirli karışımı koyun, sigara şeklinde sarıp kızartın."
                },
                new Food
                {
                    ID = 38,
                    Name = "Köy Ekmek",
                    Materials = "Un, su, maya, tuz, şeker",
                    HowManyPerson = "8 kişilik",
                    PreparationTime = "20 dakika",
                    CookingTime = "60+ dakika",
                    RecipeExplanation = "Un, su, maya, tuz ve şekeri yoğurun. Hamuru mayalandırıp fırında pişirin."
                },
                new Food
                {
                    ID = 39,
                    Name = "Pizza",
                    Materials = "Pizza hamuru, domates sosu, mozzarella peyniri, sucuk, zeytin, mantar, zeytinyağı",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "20 dakika",
                    CookingTime = "25 dakika",
                    RecipeExplanation = "Hamuru açıp üzerine sos ve malzemeleri ekleyin. Fırında pişirin."
                },
                new Food
                {
                    ID = 40,
                    Name = "Poğaça",
                    Materials = "Un, süt, yumurta, margarin, maya, tuz, beyaz peynir",
                    HowManyPerson = "12 kişilik",
                    PreparationTime = "20 dakika",
                    CookingTime = "25 dakika",
                    RecipeExplanation = "Hamuru yoğurun ve mayalandırın. Peynirli harcı koyup şekil verin, fırında pişirin."
                },


                new Food
                {
                    ID = 41,
                    Name = "Menemen",
                    Materials = "Domates, yeşil biber, yumurta, zeytinyağı, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "10 dakika",
                    CookingTime = "15 dakika",
                    RecipeExplanation = "Biberleri ve domatesleri zeytinyağında kavurun, yumurtaları ekleyip karıştırarak pişirin."
                },
                new Food
                {
                    ID = 42,
                    Name = "Sahanda Yumurta",
                    Materials = "Yumurta, tereyağı, tuz, karabiber",
                    HowManyPerson = "2 kişilik",
                    PreparationTime = "5 dakika",
                    CookingTime = "10 dakika",
                    RecipeExplanation = "Tereyağında yumurtaları kırıp pişirin. Tuz ve karabiberle tatlandırın."
                },
                new Food
                {
                    ID = 43,
                    Name = "Kahvaltılık Peynir Tabağı",
                    Materials = "Çeşitli peynirler (beyaz peynir, kaşar, lor), zeytin, domates, salatalık, zeytinyağı",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "10 dakika",
                    CookingTime = "0 dakika",
                    RecipeExplanation = "Peynirleri dilimleyip tabağa yerleştirin. Zeytin, domates ve salatalık ekleyin."
                },
                new Food
                {
                    ID = 44,
                },
                new Food
                {
                    ID = 45,
                    Name = "Yumurtalı Sosis",
                    Materials = "Sosis, yumurta, tereyağı, tuz, karabiber",
                    HowManyPerson = "2 kişilik",
                    PreparationTime = "5 dakika",
                    CookingTime = "10 dakika",
                    RecipeExplanation = "Sosisleri tereyağında kızartın. Üzerine yumurtayı kırıp pişirin, tuz ve karabiberle tatlandırın."
                },

                new Food
                {
                    ID = 46,
                    Name = "Spaghetti Carbonara",
                    Materials = "Spaghetti, yumurta, parmesan peyniri, pastırma, sarımsak, zeytinyağı, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "15 dakika",
                    CookingTime = "20 dakika",
                    RecipeExplanation = "Spaghettiyi haşlayın. Pastırmayı ve sarımsağı zeytinyağında kavurun, yumurta ve peynir karışımını ekleyin. Spaghettiyi karışıma ekleyip karıştırın."
                },
                new Food
                {
                    ID = 47,
                    Name = "Fettucine Alfredo",
                    Materials = "Fettucine, tereyağı, krema, parmesan peyniri, sarımsak, tuz, karabiber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "10 dakika",
                    CookingTime = "15 dakika",
                    RecipeExplanation = "Fettucineyi haşlayın. Tereyağını eritip kremayı ekleyin, peynirle karıştırın. Sosu makarnaya döküp karıştırın."
                },
                new Food
                {
                    ID = 48,
                    Name = "Penne Arrabbiata",
                    Materials = "Penne, domates sosu, kırmızı biber, sarımsak, zeytinyağı, tuz, karabiber, maydanoz",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "10 dakika",
                    CookingTime = "20 dakika",
                    RecipeExplanation = "Penneyi haşlayın. Sarımsağı ve kırmızı biberi zeytinyağında kavurun, domates sosunu ekleyin. Sosu makarnaya döküp maydanoz ile süsleyin."
                },
                new Food
                {
                    ID = 49,
                    Name = "Mac and Cheese",
                    Materials = "Makarna, cheddar peyniri, süt, tereyağı, un, tuz, karabiber, muskat cevizi",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "10 dakika",
                    CookingTime = "30 dakika",
                    RecipeExplanation = "Makarna haşlanır. Sos için tereyağı ve unu kavurun, süt ekleyip koyulaşana kadar pişirin. Peynirleri ekleyip eritin. Sosu makarnaya dökün, fırında 15 dakika pişirin."
                },
                new Food
                {
                    ID = 50,
                    Name = "Bolognese Soslu Makarna",
                    Materials = "Makarna, kıyma, domates sosu, soğan, sarımsak, havuç, kereviz, zeytinyağı, tuz, karabiber, kekik",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "15 dakika",
                    CookingTime = "45 dakika",
                    RecipeExplanation = "Kıymayı soğan, sarımsak, havuç ve kereviz ile kavurun. Domates sosunu ekleyip kısık ateşte pişirin. Makarnayı haşlayıp sosla karıştırın."
                },


                new Food
                {
                    ID = 51,
                    Name = "Zeytinyağlı Enginar",
                    Materials = "Enginar, zeytinyağı, limon, soğan, havuç, bezelye, tuz, karabiber, dereotu",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "20 dakika",
                    CookingTime = "40 dakika",
                    RecipeExplanation = "Enginarları limonlu suya bekletin. Soğanı ve havucu zeytinyağında kavurun. Enginarları ekleyip bezelye ve su ilave edin. Piştikten sonra dereotu ile süsleyin."
                },
                new Food
                {
                    ID = 52
                },
                new Food
                {
                    ID = 53,
                    Name = "Patates Yemeği",
                    Materials = "Patates, soğan, domates, biber, zeytinyağı, tuz, karabiber, pul biber",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "15 dakika",
                    CookingTime = "30 dakika",
                    RecipeExplanation = "Patatesleri ve soğanları doğrayıp zeytinyağında kavurun. Domates ve biberleri ekleyin, baharatlarla tatlandırın. Kısık ateşte pişirin."
                },
                new Food
                {
                    ID = 54,
                    Name = "Fırında Kabak",
                    Materials = "Kabak, zeytinyağı, sarımsak, tuz, karabiber, kekik, parmesan peyniri",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "10 dakika",
                    CookingTime = "25 dakika",
                    RecipeExplanation = "Kabları dilimleyip zeytinyağı, sarımsak ve baharatlarla harmanlayın. Fırın tepsisine dizip parmesan peyniri serpin, fırında pişirin."
                },
                new Food
                {
                    ID = 55,
                    Name = "Karnabahar Kızartması",
                    Materials = "Karnabahar, un, yumurta, tuz, karabiber, sıvı yağ",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "15 dakika",
                    CookingTime = "20 dakika",
                    RecipeExplanation = "Karnabaharları çiçeklerine ayırın. Un ve yumurtaya bulayıp sıvı yağda kızartın. Tuz ve karabiber ile tatlandırın."
                },


                new Food
                {
                    ID = 56,
                    Name = "Sütlaç",
                    Materials = "Pirinç, süt, şeker, vanilin, su, tarçın",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "10 dakika",
                    CookingTime = "45 dakika",
                    RecipeExplanation = "Pirinçleri suyla haşlayın. Sütü ve şekeri ekleyip karıştırarak pişirin. Vanilini ekleyip karıştırın. Kaselere döküp soğutun, tarçın serpin."
                },
                new Food
                {
                    ID = 57,
                    Name = "Baklava",
                    Materials = "Yufka, ceviz, tereyağı, şeker, su, limon suyu",
                    HowManyPerson = "8 kişilik",
                    PreparationTime = "30 dakika",
                    CookingTime = "45 dakika",
                    RecipeExplanation = "Yufkaları tereyağı ile yağlayarak üst üste koyun. Cevizi serpin ve dilimleyin. Fırında pişirip şerbet dökün."
                },
                new Food
                {
                    ID = 58,
                    Name = "Kumpir",
                    Materials = "Patates, tereyağı, kaşar peyniri, zeytin, mısır, sosis, mayonez, ketçap, tuz",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "15 dakika",
                    CookingTime = "60+ dakika",
                    RecipeExplanation = "Patatesleri fırında pişirin. Kumpirleri kesip içlerini tereyağı ve kaşar ile karıştırın. Üzerine zeytin, mısır, sosis ve sosları ekleyin."
                },
                new Food
                {
                    ID = 59,
                    Name = "Revani",
                    Materials = "Yumurta, şeker, un, irmik, yoğurt, kabartma tozu, limon suyu, şeker",
                    HowManyPerson = "8 kişilik",
                    PreparationTime = "15 dakika",
                    CookingTime = "30 dakika",
                    RecipeExplanation = "Yumurta ve şekeri çırpın, diğer malzemeleri ekleyip karıştırın. Fırında pişirin ve soğuduktan sonra şerbet dökün."
                },
                new Food
                {
                    ID = 60,
                    Name = "Puding",
                    Materials = "Süt, şeker, kakao, nişasta, vanilin",
                    HowManyPerson = "4 kişilik",
                    PreparationTime = "10 dakika",
                    CookingTime = "20 dakika",
                    RecipeExplanation = "Süt, şeker ve kakao karışımını kaynatın. Nişasta ve vanilini ekleyip karıştırarak pişirin. Kaselere döküp soğutun."
                }


            );

        }
    }
}
