namespace Entities.DTOs;
public record ExampleDto
{
    public string Title { get; set; }
    public DateTime ExampleDate { get; set; }
    public List<QuestionDto> QuestionDtos { get; set; }
    public List<GunQuestionDto> GunQuestionDtos { get; set; }
}