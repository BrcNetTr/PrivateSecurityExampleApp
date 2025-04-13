
using AutoMapper;
using Entities.DTOs;
using Entities.Models;

namespace MvcApp.Infrastructure.AutoMapper;

public class MappingProfile:Profile
{
    public MappingProfile()
    {
        CreateMap<ExampleDto, Example>();
    }
}
