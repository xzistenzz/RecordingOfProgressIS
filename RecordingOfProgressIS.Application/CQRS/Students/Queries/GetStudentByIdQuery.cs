using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RecordingOfProgressIS.ApplicationContract.Dtos;
using RecordingOfProgressIS.Infrastructure.Context;

namespace RecordingOfProgressIS.Application.CQRS.Students.Queries;

public record GetStudentByIdQuery(int StudentId) : IRequest<StudentDto>;

public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQuery, StudentDto>
{
    private readonly IMapper _mapper;
    private readonly RopisDbContext  _context;

    public GetStudentByIdQueryHandler(IMapper mapper, RopisDbContext context)
    {
        _mapper = mapper;
        _context = context;
    }

    public async Task<StudentDto> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
    {
        var student = await _context.Students.AsNoTracking()
            .FirstOrDefaultAsync(x => x.Id == request.StudentId, cancellationToken);
        
        return _mapper.Map<StudentDto>(student);
    }
}