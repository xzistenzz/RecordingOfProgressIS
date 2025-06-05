using MediatR;
using RecordingOfProgressIS.ApplicationContract.Requests;
using RecordingOfProgressIS.Domain.Models;
using RecordingOfProgressIS.Infrastructure.Context;

namespace RecordingOfProgressIS.Application.CQRS.Students.Commands
{
    public record CreateStudenCommand(CreateStudentRequest data) : IRequest<int>;

    public class CreateStudentCommandHandler : IRequestHandler<CreateStudenCommand, int>
    {
        private readonly RopisDbContext _context;

        public CreateStudentCommandHandler(RopisDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateStudenCommand request, CancellationToken cancellationToken)
        {
            var student = new Student { Name = request.data.Name, MailAdress = request.data.MailAdress };
            _context.Students.Add(student);
            await _context.SaveChangesAsync(cancellationToken);

            return student.Id;
        }
    }
}
