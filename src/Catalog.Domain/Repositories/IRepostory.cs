using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.Repositories
{
    public interface IRepostory
    {
        IUnitOfWork UnitOfWork { get; }
    }
}
