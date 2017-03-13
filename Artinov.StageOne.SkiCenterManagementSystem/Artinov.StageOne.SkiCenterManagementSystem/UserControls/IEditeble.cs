using System;
using System.Collections.Generic;

namespace Artinov.StageOne.SkiCenterManagementSystem
{
    public interface IEditeble
    {
        void Delete();
        void Edit();
        void Add();
        void FillControl(Dictionary<string, int> columns, string[][] elements);
    }

    public delegate void CallbackRefresh(IEditeble control);
}