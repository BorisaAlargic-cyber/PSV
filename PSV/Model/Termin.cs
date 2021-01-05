using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Model
{
    public class Termin : BaseModel
    {
        public DateTime Date { get; set; }
        public User Doctor { get; set; }
        public bool Taken { get; set; }
    }
}
