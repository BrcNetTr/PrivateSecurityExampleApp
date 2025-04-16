
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Configuration;

public class QuestionConfig : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.HasData(
            new Question
            {
                Id = 1,
                ExampleId=1,
                Content = "1. Türkiye’de özel güvenlik anlayışınıntemeli 1981 yılında 2945 sayılı Kanun ileatılmıştır.BuKanunuyürürlüktenkaldıran ve halen yürürlükte olan 5188sayılı Özel Güvenlik Hizmetlerine DairKanun hangi tarihte yürürlüğe girmiştir?",
                OptionA = "A) 2000",
                OptionB = "B) 2002",
                OptionC = "C) 2004",
                OptionD = "D) 2006",
                OptionE = "E) 2008",
                TrueOption = "C",
                CreateDate = new DateTime(2025, 4, 10)
            },
             new Question
            {
                Id = 2,
                ExampleId=1,
                Content = "2. 5188sayılı Özel Güvenlik Hizmetlerine Dair   Kanunun   7’inci   maddesinde belirtilen  “Özel  güvenlik  görevlilerinin yetkileri”  ile  ilgili  aşağıdaki  ifadelerden hangisi yanlıştır?",
                OptionA = "A) Terk  edilmiş  ve  bulunmuş  eşyayı emanete alma",
                OptionB = "B) Olay  yerinde delil  toplama  ve  mağdurun ifadesini alma",
                OptionC = "C) Tabiî  afet  durumlarında  ve  imdat istenmesi halinde görev alanındaki işyeri ve konutlara girme",
                OptionD = "D) Görev  alanında,  haklarında  yakalama emri bulunan kişileri yakalama ve arama",
                OptionE = "E) Kişinin vücudu veya sağlığı bakımından mevcut  bir  tehlikeden  korunması  amacıyla yakalama",
                TrueOption = "B",
                CreateDate = new DateTime(2025, 4, 10)
                
            },
            new Question
            {
                Id = 3,
                ExampleId=1,
                Content = "3.Yabancıkişilerin özel güvenlik şirketi kurabilmesi   ve   yabancı   şirketlerin Türkiye’de   özel   güvenlik   hizmeti verebilmesinde aranan temel ilke nedir? ",
                OptionA = "A) Mülkilik",
                OptionB = "B) Şahsilik",
                OptionC = "C) Koruma",
                OptionD = "D) Evrensellik",
                OptionE = "E) Mütekabiliyet",
                TrueOption = "E",
                CreateDate = new DateTime(2025, 4, 10)
                
            }
           
        );
    }
}
