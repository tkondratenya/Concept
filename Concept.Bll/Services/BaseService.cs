using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Concept.Dal.Interfaces;
using Concept.Bll.Interfaces;

namespace Concept.Bll.Services
{
    public class BaseService : IBaseService
    {
        public IUnitOfWork Database { get; set; }

        public BaseService(IUnitOfWork uow)
        {
            Database = uow;
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
