using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Model
{
    public class Recepie : BaseModel
    {
        public User Pacient;
        public User Doctor;
        public Drugs Drug;
        public int quantity;
    }
}
