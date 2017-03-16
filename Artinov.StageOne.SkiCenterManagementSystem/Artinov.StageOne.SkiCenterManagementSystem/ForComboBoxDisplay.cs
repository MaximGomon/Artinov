using System;

namespace Artinov.StageOne.SkiCenterManagementSystem
{
    public class ForComboBoxDisplay
    {
        public Guid Id { get; set; }
        public string DisplayText { get; set; }
        public override string ToString()
        {
            return DisplayText;
        }
    }
}