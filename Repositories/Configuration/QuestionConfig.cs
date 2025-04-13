
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
                Content = "Türkiye’de özel güvenlik anlayışınıntemeli 1981 yılında 2945 sayılı Kanun ileatılmıştır.BuKanunuyürürlüktenkaldıran ve halen yürürlükte olan 5188sayılı Özel Güvenlik Hizmetlerine DairKanun hangi tarihte yürürlüğe girmiştir?",
                OptionA = "2000",
                OptionB = "2002",
                OptionC = "2004",
                OptionD = "2006",
                OptionE = "2008",
                TrueOption = "C"
            }
        );
    }
}
