using AutoMapper;


namespace CourseLibraryAPI.Profiles
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<Entities.Course, CourseLibrary.API.Models.CourseDto>();
            CreateMap<CourseLibrary.API.Models.CourseForCreationDto, Entities.Course>();
            CreateMap<CourseLibrary.API.Models.CourseForUpdateDto,Entities.Course>();
            CreateMap<Entities.Course, CourseLibrary.API.Models.CourseForUpdateDto>();
        }
    }
}
