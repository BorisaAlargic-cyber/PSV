using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Model
{
    public class Visit : BaseModel
    {
        public Apointment Apointment { get; set; }

        public String  Results { get; set; }

    }
}
