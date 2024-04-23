using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Incubator
    {
        public Guid Id {get; set;}
        public string NumePasare {get; set;}
        public int ZileFormare { get; set; }
        public DateTime ZiIncepere { get; set; }
        public DateTime ZiFinal {get;set; }
        public string TempOptima { get; set; }
        public string TempSetata { get; set; }
        public string TempCurenta { get; set; }
        public bool StareBec{ get; set; }
    }
}