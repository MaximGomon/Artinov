using System;
using System.Collections.Generic;

namespace Artinov.StageOne.SkiCenterManagementSystem
{
    public interface IEditeble
    {
        void Delete(CallbackRefresh refresh, Guid id, IFilleble control);
        void Edit(CallbackRefresh refresh, Guid id, IFilleble control);
        void Add(CallbackRefresh refresh, IFilleble control);
    }
}