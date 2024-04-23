using Domain;
using MediatR;
using Newtonsoft.Json;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace Application.Incubatoare
{

    public class List
    {
       public class Query:IRequest<List<Incubator>> {}
        public class Handler : IRequestHandler<Query, List<Incubator>>
        {
            private readonly DataContext _context;
            private readonly ILogger<List> _logger;

            public Handler(DataContext context,ILogger<List>logger){
                _context = context;
                _logger = logger;
            }
            public async Task<List<Incubator>> Handle(Query request, CancellationToken cancellationToken)
            {
             
                return await _context.Incubatoare.ToListAsync();
            }
        }
    }
}