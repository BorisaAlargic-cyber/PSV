using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Model
{
    public class Instruction : BaseModel
    {
        public User Patient { get; set; }
        public string Speciality { get; set; }
    }
}
