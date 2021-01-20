using PSV.Core;
using PSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Repository
{
    public class RecepieRepository : Repository<Recepie> , IRecepieRepository
    {
        public RecepieRepository(ModelContext context) : base(context) { }

        public Recepie GetRecepieById(int id)
        {
            return ModelContext.Recepie.Where(x => x.Id == id).FirstOrDefault();
        }

        public override PageResponse<Recepie> GetPage(Pager pager)
        {
            var query = ModelContext.Recepie.Where(x => (x.Deleted == false)).OrderBy(x => x.Id);

            return new PageResponse<Recepie>(query.Skip(pager.Page).Take(pager.PerPage).ToList(), query.Count());
        }
    }
}
