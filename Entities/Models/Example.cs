using Entities.Models.Common;

namespace Entities.Models;
public class Example:BaseEntity
{
    public int Id { get; set; }
    public string Title { get; set; }
    public DateTime ExampleDate { get; set; }
    public ICollection<Question> Questions { get; set; }
    public ICollection<GunQuestion> GunQuestions { get; set; }
}