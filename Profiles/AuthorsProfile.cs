using AutoMapper;
using CourseLibraryAPI.Helpers;


namespace CourseLibraryAPI.Profiles
{
    public class AuthorsProfile : Profile
    {
        public AuthorsProfile()
        {
            CreateMap<Entities.Author, CourseLibrary.API.Models.AuthorDto>()
                .ForMember(
                    dest => dest.Name, 
                    opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(
                    dest => dest.Age, 
                    opt => opt.MapFrom(src => src.DateOfBirth.GetCurrentAge()));

            CreateMap<CourseLibrary.API.Models.AuthorForCreationDto, Entities.Author>();
        }
    }
}
