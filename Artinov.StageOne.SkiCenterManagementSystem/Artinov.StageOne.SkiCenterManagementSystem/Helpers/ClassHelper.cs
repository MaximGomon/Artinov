using Artinov.StageOne.SkiCenterManagementSystem.SkiServiceReference;

namespace Artinov.StageOne.SkiCenterManagementSystem.Helpers
{
    public static class ClassHelper
    {
        public static string GetClientForDisplay(this ClientModel model)
        {
            return $"{model.Name} {model.Sex} Age:{model.Age}";
        }
    }
}