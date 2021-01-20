using PSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Core
{
    public interface IRecepieRepository : IRepository<Recepie>
    {
        public Recepie GetRecepieById(int id);
    }
}
