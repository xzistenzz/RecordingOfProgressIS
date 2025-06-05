using RecordingOfProgressIS.ApplicationContract.Dtos;
using RecordingOfProgressIS.Domain.Models;

namespace RecordingOfProgressIS.Application.Profile;

public class StudentProfile : AutoMapper.Profile
{
    public StudentProfile()
    {
        CreateMap<Student, StudentDto>();
    }
}