using PSV.Core;
using PSV.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PSV.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ModelContext context;

        public UnitOfWork(ModelContext context)
        {
            this.context = context;
            Users = new UserRepository(this.context);
            Apointment = new ApointmentRepository(this.context);
            Feedback = new FeedbackRepository(this.context);
            Instruction = new InstructionRepository(this.context);
            Termin = new TerminRepository(this.context);

        }
        public IUserRepository Users { get; private set; }
        public IApointmentRepository Apointment { get; private set; }
        public IFeedbackRepository Feedback { get; private set; }
        public IInstructionRepository Instruction { get; private set; }
        public ITerminRepository Termin { get; private set; }

        public ModelContext Context
        {
            get { return context; }
        }
        public int Complete()
        {
            return context.SaveChanges();
        }
        public void Dispose()
        {
            context.Dispose();
        }
    }
}
