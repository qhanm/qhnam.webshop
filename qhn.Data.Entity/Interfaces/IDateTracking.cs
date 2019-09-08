using System;

namespace qhn.Data.Entity.Interfaces
{
    public interface IDateTracking
    {
        DateTime DateCreated { set; get; }

        DateTime DateModified { set; get; }
    }
}