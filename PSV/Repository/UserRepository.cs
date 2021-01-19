using PSV.Core;
using PSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Repository
{
    public class UserRepository : Repository<User> , IUserRepository
    {
        public UserRepository(ModelContext context) : base(context) { }

        public User GetUserWithEmail(string email)
        {
            return ModelContext.Users.Where(x => x.Email == email).FirstOrDefault();
        }

        public User GetUserWithEmailAndPassword(string email, string password)
        {
            return ModelContext.Users.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
        }

        public override PageResponse<User> GetPage(Pager pager)
        {
            var query = ModelContext.Users.Where(x => (x.Deleted == false)).OrderBy(x => x.Id);

            return new PageResponse<User>(query.Skip(pager.Page).Take(pager.PerPage).ToList(), query.Count());
        }
    }
}
