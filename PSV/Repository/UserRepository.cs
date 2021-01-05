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
    }
}
