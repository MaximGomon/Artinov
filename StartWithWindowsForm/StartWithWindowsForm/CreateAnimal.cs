using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartWithWindowsForm
{
    public partial class CreateAnimal : Form
    {
        private readonly Guid _animalId;
        private readonly ElementState _state;
        public CreateAnimal(Animal item)
        {
            InitializeComponent();
            FillComboBox();
            tbName.Text = item.Name;
            cbSize.SelectedItem = (object) item.Size;
            _animalId = item.Id;
            _state = ElementState.Edit;

            this.Text = $"Edit animal {item.Name}";
        }

        public CreateAnimal()
        {
            InitializeComponent();
            FillComboBox();
            _state = ElementState.New;

            this.Text = "Create new animal";
        }

        private void FillComboBox()
        {
            object[] elements = Enum.GetValues(typeof (AnimalSize)).Cast<object>().ToArray();
            cbSize.Items.AddRange(elements);
            cbSize.SelectedIndex = 0;
        }

        private void CreateAnimal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                if(_state == ElementState.Edit)
                {
                    var editedEnimalIndex = AnimalStorage.Animals.FindIndex(x => x.Id == _animalId);
                    AnimalStorage.Animals.RemoveAt(editedEnimalIndex);
                }

                Animal item = new Animal
                {
                    Name = tbName.Text.Trim(),
                    Size = (AnimalSize)cbSize.SelectedItem
                };
                AnimalStorage.Animals.Add(item);
            }
        }
    }
}
