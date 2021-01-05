using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Model
{
    public class Feedback : BaseModel
    {
        public User Patient { get; set; }
        public string Comment { get; set; }
        public bool Published { get; set; }
    }
}
