
namespace Entities.Models;

public class Question
{
   public int Id { get; set; }
   public int ExampleId { get; set; }
   public string Content { get; set; }
   public string OptionA { get; set; }
   public string OptionB { get; set; }
   public string OptionC { get; set; }
   public string OptionD { get; set; }
   public string OptionE { get; set; }
   public string TrueOption { get; set; }

}
