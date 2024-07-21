using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Recipe.Entities.EntityConfig.Abstract;
using Recipe.Entities.Model.Concrete;

namespace Recipe.Entities.EntityConfig.Concrete
{
    public class InfoConfig : BaseConfig<Info, int>
    {
        public override void Configure(EntityTypeBuilder<Info> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.inf).HasMaxLength(500);
            builder.HasData(
           new Info
           {
               ID = 1,
               inf = "Yemeklerin lezzeti büyük ölçüde kullanılan malzemelerin kalitesine bağlıdır. Taze ve kaliteli malzemeler kullanmaya özen gösterin."
           },
           new Info
           {
               ID = 2,
               inf = "Tarife sadık kalmak, doğru miktarda malzeme kullanmak önemlidir. Özellikle tuz, baharat ve şeker gibi tatları dikkatlice ölçün."
           },
           new Info
           {
               ID = 3,
               inf = "Yemek yapmaya başlamadan önce tüm malzemeleri hazırlayın. Bu, yemek yapma sürecini daha düzenli ve hızlı hale getirir."
           },
           new Info
           {
               ID = 4,
               inf = "Pişirme sırasında ısıyı doğru ayarlamak önemlidir. Kısık ateşte pişirilen yemekler genellikle daha lezzetli ve dengeli olur."
           },
           new Info
           {
               ID = 5,
               inf = "Baharatları yemeklerin pişirme sürecinin başında değil, genellikle sonlarına doğru eklemek, baharatların aromasını kaybetmesini engeller."
           },
           new Info
           {
               ID = 6,
               inf = "Pişirdiğiniz yemekleri servisten önce bir süre dinlendirmek, lezzetlerin birbirine karışmasına ve yemeklerin daha iyi bir tat profilinin oluşmasına yardımcı olur."
           },
           new Info
           {
               ID = 7,
               inf = "Yemekleri gereğinden fazla pişirmek lezzetlerini kaybettirebilir. Tarife göre önerilen süreleri dikkate alın ve pişirme süresini kontrol edin."
           },
           new Info
           {
               ID = 8,
               inf = "Yemeklerde tuz ve şeker miktarını dengelemek önemlidir. Tatları dengede tutmak için küçük miktarlarda ekleyin ve tadına bakarak ayarlayın."
           },
           new Info
           {
               ID = 9,
               inf = "Sosları yemeklerin üzerine dökmeden önce, sosun kıvamını ve tadını kontrol edin. Sosları yemekle aynı anda pişirmek, daha iyi bir uyum sağlar."
           },
           new Info
           {
               ID = 10,
               inf = "Yemeklerin sunumu da en az lezzeti kadar önemlidir. Güzel bir sunum, yemeklerin tadını daha da artırabilir ve iştah açıcı hale getirebilir."
           });
        }
    }
}
