using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Model
{
    public class Apointment : BaseModel
    {
        public User Patient { get; set; }
        public DateTime Date { get; set; }
        public User Doctor { get; set; }
        public bool Taken { get; set; }
        public string Comment { get; set; }
    }
}
