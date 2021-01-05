using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Model
{
    public class Apointment : BaseModel
    {
        public User Patient { get; set; }
        public Termin Termin { get; set; }
    }
}
