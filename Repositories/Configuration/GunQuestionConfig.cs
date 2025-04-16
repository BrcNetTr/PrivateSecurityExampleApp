using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Configuration;
public class GunQuestionConfig : IEntityTypeConfiguration<GunQuestion>
{
    public void Configure(EntityTypeBuilder<GunQuestion> builder)
    {
        builder.HasData(
            new GunQuestion
            {
                Id = 1,
                ExampleId = 1,
                Content = @"1. Fişek yatağında fişek bulunan tabancanın güvenli bir şekilde boşaltılması için sırasıyla izlenmesigereken yol nasıl olmalıdır?  
                    I - Tabanca ölü noktaya çevrilir  
                    II- Sürgü çekilip gözle fişek yatağı 
                    kontrol edilir ve bırakılır 
                    III- Şarjör çıkartılır 
                    IV- Ölü bölgeye tetik düşürülerek silah 
                    kılıfa konulur ",
                OptionA = "A) I, III, II, IV ",
                OptionB = "B) III, II, I,IV",
                OptionC = "C) IV, I,II, III ",
                OptionD = "D) III, IV, I, II ",
                OptionE = "E) II, IV, III, I",
                TrueOption = "A",
                CreateDate = new DateTime(2025, 4, 10)

            },
            new GunQuestion
            {
                Id = 2,
                ExampleId = 1,
                Content = @"2. Aşağıdakilerden hangileri silahın dolduruş yapmasına engel nedenlerden değildir?  
                I. Şarjörde fişek olmayabilir 
                II. İğne yayı kırık olabilir 
                III. Şarjör tutucu pimi arızalı olabilir 
                IV. Barut miktarı az olabilir  
                V.  Şarjörde hatalı fişek olabilir.   ",
                OptionA = "A) I-II ",
                OptionB = "B) I-III-V ",
                OptionC = "C) II-IV",
                OptionD = "D) III-IV ",
                OptionE = "E) I-II-IV",
                TrueOption = "C",
                CreateDate = new DateTime(2025, 4, 10)

            },
            new GunQuestion
            {
                Id = 3,
                ExampleId = 1,
                Content = @"3. Aşağıdakilerden hangisinde tabancanın sökülme sırası doğru olarak verilmiştir?  
                I. Kapak takımını çıkart (sürgü) 
                II. Şarjörü çıkart  
                III. Yerine getiren yayı çıkart 
                IV. Namluyu çıkart 
                V. Fişek yatağını kontrol et ",
                OptionA = "A) II-I-IV-III-V ",
                OptionB = "B) V-IV-III-II-I ",
                OptionC = "C) II-V-I-III-IV ",
                OptionD = "D) III-II-I-V-IV",
                OptionE = "E) IV-I-V-III-II ",
                TrueOption = "C",
                CreateDate = new DateTime(2025, 4, 10)

            }
        );
    }
}