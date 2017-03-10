using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Artinov.StageOne.SkiCenterManagementSystem.SkiServiceReference;

namespace Artinov.StageOne.SkiCenterManagementSystem
{
    public partial class ShowAllElements<T> : UserControl, IEditeble where T : IdEntity
    {
        public ShowAllElements(Dictionary<string, string> columns, List<T> elements)
        {
            InitializeComponent();
        }

        public ShowAllElements()
        {
            
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Edit()
        {
            throw new NotImplementedException();
        }

        public void Add()
        {
            throw new NotImplementedException();
        }
    }
}
