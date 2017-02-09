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
    public partial class UcEditAnimal : UserControl, IAnimalStorage
    {
        private readonly Animal _editedItem;
        public UcEditAnimal(Animal item)
        {
            InitializeComponent();

            FillComboBox();
            _editedItem = item;
            tbName.Text = item.Name;
            cbSize.SelectedItem = (object)item.Size;
        }
        public Animal GetAnimal()
        {
            _editedItem.Name = tbName.Text.Trim();
            _editedItem.Size = (AnimalSize)cbSize.SelectedItem;
            return _editedItem;
        }

        private void FillComboBox()
        {
            object[] elements = Enum.GetValues(typeof(AnimalSize)).Cast<object>().ToArray();
            cbSize.Items.AddRange(elements);
            cbSize.SelectedIndex = 0;
        }

        
    }
}
