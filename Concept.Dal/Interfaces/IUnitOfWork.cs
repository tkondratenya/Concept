using Concept.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concept.Dal.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Resource> Resources { get; }
        IRepository<ResourceCost> ResourceCosts { get; }
        IRepository<Cost> Costs { get; }
        void Save();
        void Truncate();
    }
}
