using PSV.Core;
using PSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Repository
{
    public class InstructionRepository : Repository<Instruction> , IInstructionRepository
    {
        public InstructionRepository(ModelContext context) : base(context) { }
    }
}
