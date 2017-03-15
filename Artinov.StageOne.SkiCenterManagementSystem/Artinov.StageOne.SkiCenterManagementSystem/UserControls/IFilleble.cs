using System.Collections.Generic;

namespace Artinov.StageOne.SkiCenterManagementSystem
{
    public interface IFilleble
    {
        void FillControl(Dictionary<string, int> columns, string[][] elements);
    }

    public delegate void CallbackRefresh(IFilleble control);

}