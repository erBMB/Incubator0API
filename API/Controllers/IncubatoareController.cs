using Application.Activities;
using Application.Incubatoare;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class IncubatoareController:BaseApiController
    {
       


        [HttpGet]
        public async Task<ActionResult<List<Incubator>>>GetIncubatoare(){
          return await Mediator.Send(new List.Query()); 

        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Incubator>> GetIncubator(Guid id){
             return await Mediator.Send(new Details.Query{Id=id});
        }

        [HttpGet("logIncubator")]
        public async Task<ActionResult<List<LogIncubator>>>GetLogIncubatoare(){
            return await Mediator.Send(new LoguriIncubator.Query()); 
        }

      [HttpGet("datefilteredLog/{start}/{end}")]
        public async Task<ActionResult<List<LogIncubator>>>GetDateFilteredLog(string start, string end){

            return await Mediator.Send(new DateFilteredLog.Query{StartDate=start, EndDate=end});
        }

        [HttpGet("datetime")]
    public IActionResult GetDateTime()
    {
        // Get the current date and time
        DateTime currentDateTime = DateTime.Now;

         string formattedDateTime = currentDateTime.ToString("yyyy_MM_dd@HH_mm_ss");

        // Return the current date and time as a JSON response
        return Ok(new { DateTime = formattedDateTime });
    }

    [HttpPost("incubator")]
    public async Task<IActionResult> CreateIncubator(Incubator incubator) 
    {
        await Mediator.Send(new CreateIncubator.Command{Incubator=incubator});
        return Ok();
    }
     [HttpPost("logIncubator")]
    public async Task<IActionResult> CreateLogIncubator(LogIncubator logIncubator) 
    {
        await Mediator.Send(new CreateLogIncubator.Command{LogIncubator=logIncubator});
        return Ok();
    }

    [HttpPut("editTcurenta/{id}/{temperatura}")]
   public async Task<IActionResult>EditTempIncubator(Guid id,string temperatura)
    {
        await Mediator.Send(new EditTempIncubator.Command{Id=id,Temperatura=temperatura});
        return Ok();
    }
     [HttpPut("{id}")]
   public async Task<IActionResult>EditIncubator(Guid id, Incubator incubator)
    {
        incubator.Id=id;
        await Mediator.Send(new EditIncubator.Command{Incubator=incubator});
        return Ok();
    }

    }
}