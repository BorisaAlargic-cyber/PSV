using PSV.Core;
using PSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Repository
{
    public class TerminRepository : Repository<Termin> , ITerminRepository
    {
        public TerminRepository(ModelContext context) : base(context) { }
    }
}
