using PSV.Core;
using PSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Repository
{
    public class FeedbackRepository : Repository<Feedback> ,  IFeedbackRepository
    {
        public FeedbackRepository(ModelContext context) : base(context) { }

        public override PageResponse<Feedback> GetPage(Pager pager)
        {
            var query = ModelContext.Feedbacks.Where(x => (x.Deleted == false && (x.Comment.Contains(pager.Search))));

            return new PageResponse<Feedback>(query.Skip(pager.Page).Take(pager.PerPage).ToList(), query.Count());
        }

        public PageResponse<Feedback> GetPagePublished(Pager pager)
        {
            var query = ModelContext.Feedbacks.Where(x => (x.Deleted == false && (x.Published == true)));

            return new PageResponse<Feedback>(query.Skip(pager.Page).Take(pager.PerPage).ToList(), query.Count());
        }
    }
}
