using Domain;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Persistence;

namespace Application.Incubatoare
{
    public class LoguriIncubator
    {
       public class Query:IRequest<List<LogIncubator>> {}
        public class Handler : IRequestHandler<Query, List<LogIncubator>>
        {
            private readonly DataContext _context;
            private readonly ILogger<List> _logger;

            public Handler(DataContext context,ILogger<List>logger){
                _context = context;
                _logger = logger;
            }
            public async Task<List<LogIncubator>> Handle(Query request, CancellationToken cancellationToken)
            {
                try
                {
                    for(var i = 0; i <1;i++){  //de aici se modifica timpul de incarcare
                       cancellationToken.ThrowIfCancellationRequested();
                       await Task.Delay(100,cancellationToken);
                       _logger.LogInformation($"Task{i} has completed");
                    }
                }
                catch (Exception)
                {
                    
                    _logger.LogInformation("Task was cancelled");
                }
                return await _context.LogIncubatoare.ToListAsync();
            }
        }
    }
}