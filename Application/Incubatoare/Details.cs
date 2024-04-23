using Domain;
using MediatR;
using Persistence;
using System;

namespace Application.Incubatoare
{
    public class Details
    {
        public class Query:IRequest<Incubator>{
            public Guid Id {get;set;}
        }

        public class Handler:IRequestHandler<Query,Incubator>{
        private readonly DataContext _context;
            public Handler(DataContext context)
            {
            _context = context;  
            }

            public async Task<Incubator> Handle(Query request, CancellationToken cancellationToken)
            {
                return await _context.Incubatoare.FindAsync(request.Id);
            }
        }
    }
}