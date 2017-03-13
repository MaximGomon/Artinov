using System;
using Artinov.StageOne.SkiCenterManagementSystem.SkiServiceReference;

namespace Artinov.StageOne.SkiCenterManagementSystem.Helpers
{
    public static class ServiceHelper
    {
        public static SkiServiceClient Client { get; } = new SkiServiceClient();
    }
}