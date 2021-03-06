﻿using PSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Core
{
     public interface IVisitRepository : IRepository<Visit>
    {
        public Visit GetVisitById(int id);
    }
}
