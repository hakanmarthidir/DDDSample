using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSample.InfrastructureLayer.Uow
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        TContext Context { get; }
        int Save();
    }
}
