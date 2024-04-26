using MediatR;
using Persistence;

namespace Application.Activities
{
    public class DeleteLog
    {
        public class Command:IRequest{
        public Guid Id{ get; set; } 
        }

        public class Handler : IRequestHandler<Command>
        {
            private readonly DataContext _context;
            public Handler(DataContext context)
            {
               _context=context; 
            }

            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
               var logIncubator=await _context.LogIncubatoare.FindAsync(request.Id);
               _context.Remove(logIncubator);
               await _context.SaveChangesAsync();
            }
        }
    }
}