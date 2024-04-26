using MediatR;
using Persistence;

namespace Application.Activities
{
    public class DeleteIncubator
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
               var incubator=await _context.Incubatoare.FindAsync(request.Id);
               _context.Remove(incubator);
               await _context.SaveChangesAsync();
            }
        }
    }
}