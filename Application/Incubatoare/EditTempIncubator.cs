using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class EditTempIncubator
    {
        public class Command:IRequest{
            public Guid Id { get; set; } 
            public string Temperatura { get; set; } 
        }

        public class Handler : IRequestHandler<Command>
        {
        private readonly DataContext _context;

        private readonly IMapper _mapper;
            public Handler(DataContext context, IMapper mapper)
            {
            _mapper = mapper;
            _context = context;
            }

            public async Task Handle(Command request, CancellationToken cancellationToken)
            {
                var incubator=await _context.Incubatoare.FindAsync(request.Id);
               incubator.TempCurenta=request.Temperatura ?? incubator.TempCurenta;
                await _context.SaveChangesAsync();
            }
        }
    }
}