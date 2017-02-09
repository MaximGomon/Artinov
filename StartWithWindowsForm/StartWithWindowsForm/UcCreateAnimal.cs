using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartWithWindowsForm
{
    public partial class UcCreateAnimal : UserControl, IAnimalStorage
    {
        public UcCreateAnimal()
        {
            InitializeComponent();
            FillComboBox();
        }

        private void FillComboBox()
        {
            object[] elements = Enum.GetValues(typeof(AnimalSize)).Cast<object>().ToArray();
            cbSize.Items.AddRange(elements);
            cbSize.SelectedIndex = 0;
        }

        public Animal GetAnimal()
        {
            return new Animal
            {
                Name = tbName.Text.Trim(),
                Size = (AnimalSize) cbSize.SelectedItem,
                CreateDate = dtpCreateDate.Value
            };
        }
    }
}
