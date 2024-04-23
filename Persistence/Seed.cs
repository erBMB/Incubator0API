using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Incubatoare.Any()) return;
            
            var incubatoare = new List<Incubator>
            {
                new Incubator
                {
                    NumePasare="Pigeon",
                    ZileFormare=23,
                    ZiIncepere=DateTime.UtcNow.AddDays(-1),
                    ZiFinal=DateTime.UtcNow.AddMonths(1),
                    TempOptima="23",
                    TempSetata="24",
                    TempCurenta="25",
                    StareBec=false
                },
               new Incubator
                {
                    NumePasare="Duck",
                    ZileFormare=23,
                    ZiIncepere=DateTime.UtcNow.AddDays(0),
                    ZiFinal=DateTime.UtcNow.AddDays(28),
                    TempOptima="21",
                    TempSetata="25",
                    TempCurenta="26",
                    StareBec=false
                },
            };
             if (context.LogIncubatoare.Any()) return;
            
            var logIncubatoare = new List<LogIncubator>
            {
                new LogIncubator
                {
                   DataOra=DateTime.UtcNow.AddDays(0),
                   TempCurenta="23",
                   TempSetata="30"
                },
               new LogIncubator
                {
                   DataOra=DateTime.UtcNow.AddMinutes(-5),
                   TempCurenta="25",
                   TempSetata="35"
                },
                 new LogIncubator
                {
                   DataOra=DateTime.UtcNow.AddMinutes(-10),
                   TempCurenta="20",
                   TempSetata="30"
                },
                 new LogIncubator
                {
                   DataOra=DateTime.UtcNow.AddMinutes(-15),
                   TempCurenta="21",
                   TempSetata="31"
                },
            };
            

            await context.Incubatoare.AddRangeAsync(incubatoare);
            await context.LogIncubatoare.AddRangeAsync(logIncubatoare);
            await context.SaveChangesAsync();
        }
    }
}