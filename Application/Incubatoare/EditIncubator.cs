using AutoMapper;
using Domain;
using MediatR;
using Persistence;

namespace Application.Activities
{
    public class EditIncubator
    {
        public class Command:IRequest{
            public Incubator Incubator { get; set; }  
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
                var incubator=await _context.Incubatoare.FindAsync(request.Incubator.Id);
               _mapper.Map(request.Incubator,incubator);
               //incubator.TempCurenta=request.Incubator.TempCurenta?? incubator.TempCurenta;
                await _context.SaveChangesAsync();
            }
        }
    }
}