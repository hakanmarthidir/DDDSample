using DDDSample.InfrastructureLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSample.InfrastructureLayer.Uow
{
    public class UnitOfWork : IUnitOfWork<SurveyContext>
    {
        private readonly SurveyContext _context;


        public SurveyContext Context
        {
            get { return _context; }
        }

        public UnitOfWork()
        {
            this._context = new SurveyContext();
        }

        public UnitOfWork(SurveyContext context)
        {
            _context = context;
        }

        public int Save()
        {
            return _context.SaveChanges();
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                }
            }
        }

    }
}
