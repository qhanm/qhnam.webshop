using System;
using System.Collections.Generic;
using System.Text;

namespace qhnam.Data.Model.Common
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
