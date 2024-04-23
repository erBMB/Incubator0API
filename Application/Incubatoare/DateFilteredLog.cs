using MediatR;
using Persistence;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Application.Incubatoare
{
    public class DateFilteredLog
    {
       public class Query:IRequest<List<LogIncubator>> {
            public string StartDate { get;set; }
             public string EndDate { get;set; }

       }
        public class Handler : IRequestHandler<Query, List<LogIncubator>>
        {
            private readonly DataContext _context;

           

              DateTime PStartDate; 
              DateTime PEndDate ;

             public string dateFormat="yyyyMMdd";
            public Handler(DataContext context){
                _context = context;
            }
            public async Task<List<LogIncubator>> Handle(Query request, CancellationToken cancellationToken)
            {
                try
                {
                    PStartDate=DateTime.ParseExact(request.StartDate,dateFormat,null);
                    PEndDate=DateTime.ParseExact(request.EndDate,dateFormat,null);
                    Console.WriteLine(PStartDate);
                    Console.WriteLine(PEndDate);
                }
                catch (Exception)
                {
                    
                    throw;
                }

            
                // Define the date range (April 14, 2024)
           // DateTime startDate = PStartDate;
            //DateTime endDate =PEndDate;

            // Retrieve activities from the context that fall within the specified date range
           var datefilteredLog = await _context.LogIncubatoare
                 .Where(logIncubator => logIncubator.DataOra>= PStartDate && logIncubator.DataOra < PEndDate)
                .ToListAsync();
              //  return await _context.Activities.ToListAsync();
              return  datefilteredLog.ToList();
            }
        }
    }
}