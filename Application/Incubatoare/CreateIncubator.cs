using MediatR;
using Domain;
using Persistence;

namespace Application.Incubatoare
{
    public class CreateIncubator
    {
        public class Command:IRequest
        {
            public Incubator Incubator { get; set;}
        }

        public class Handler : IRequestHandler<Command>
        {
        private readonly DataContext _context;
              public Handler(DataContext context)
        {
            _context = context;
            
        }
            public async Task Handle(Command request, CancellationToken cancellationToken) //change to Task<Unit> 
            {
                _context.Incubatoare.Add(request.Incubator);
                await _context.SaveChangesAsync();  
              // return Unit.Value;
            }
        }

      
    }
}