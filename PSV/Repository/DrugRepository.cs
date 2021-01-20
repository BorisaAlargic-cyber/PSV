using PSV.Core;
using PSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Repository
{
    public class DrugRepository : Repository<Drugs> , IDrugRepository
    {
        public DrugRepository(ModelContext context) : base(context) { }

        public Drugs GetDrugById(int id)
        {
            return ModelContext.Drugs.Where(x => x.Id == id).FirstOrDefault();
        }

        public override PageResponse<Drugs> GetPage(Pager pager)
        {
            var query = ModelContext.Drugs.Where(x => (x.Deleted == false)).OrderBy(x => x.Id);

            return new PageResponse<Drugs>(query.Skip(pager.Page).Take(pager.PerPage).ToList(), query.Count());
        }
    }
}
