namespace Entities.Models;
public class Example
{
    public int Id { get; set; }
    public string Title { get; set; }
    public ICollection<Question> Questions { get; set; }
}