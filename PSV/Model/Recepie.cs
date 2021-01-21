using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Model
{
    public class Recepie : BaseModel
    {
        public User Pacient { get; set; }
        public User Doctor { get; set; }
        public Drugs Drug { get; set; }
        public int Quantity { get; set; }
    }
}
