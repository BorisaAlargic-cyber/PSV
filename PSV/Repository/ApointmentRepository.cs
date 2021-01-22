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

        public override PageResponse<Apointment> GetPage(Pager pager)
        {
            var query = ModelContext.Apointments.Include("Patient").Include("Doctor").Where(x => (x.Deleted == false)).OrderBy(x => x.Id);

            return new PageResponse<Apointment>(query.Skip(pager.Page).Take(pager.PerPage).ToList(), query.Count());
        }
    }
}
