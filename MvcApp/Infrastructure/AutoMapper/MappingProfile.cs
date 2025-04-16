
using AutoMapper;
using Entities.DTOs;
using Entities.Models;

namespace MvcApp.Infrastructure.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Question, QuestionDto>();
        CreateMap<GunQuestion, GunQuestionDto>();
        CreateMap<Example, ExampleDto>()
        .ForMember(dest => dest.QuestionDtos, opt => opt.MapFrom(src => src.Questions))
        .ForMember(dest => dest.GunQuestionDtos, opt => opt.MapFrom(src => src.GunQuestions));
    }
}
