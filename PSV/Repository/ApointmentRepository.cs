using PSV.Core;
using PSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Repository
{
    public class ApointmentRepository : Repository<Apointment> , IApointmentRepository
    {
        public ApointmentRepository(ModelContext context) : base(context) { }
    }
}
