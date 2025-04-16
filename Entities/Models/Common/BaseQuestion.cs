
namespace Entities.Models.Common;

public abstract class BaseQuestion:BaseEntity
{
    public int ExampleId { get; set; }
    public string Content { get; set; }
    public string OptionA { get; set; }
    public string OptionB { get; set; }
    public string OptionC { get; set; }
    public string OptionD { get; set; }
    public string OptionE { get; set; }
    public string TrueOption { get; set; }
}
