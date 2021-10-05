using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Repositories
{
    public interface IRepository<TAggregate, KCriteria> where TAggregate : IAggregateRoot
    {
        TAggregate Create(TAggregate item);
        TAggregate GetById(KCriteria id);
        TAggregate Update(TAggregate item);
        bool Delete(TAggregate item);
        List<TAggregate> GetAll();
    }
}
