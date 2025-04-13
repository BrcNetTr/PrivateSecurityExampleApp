
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Configuration;

public class ExampleConfig : IEntityTypeConfiguration<Example>
{
    public void Configure(EntityTypeBuilder<Example> builder)
    {
        builder.HasData(
            new Example
            {
                Id = 1,
                Title = "ÖZEL GÜVENLİK 112. TEMEL EĞİTİM YAZILI SINAV SORULARI (A GRUBU)"
            }
        );
    }
}
