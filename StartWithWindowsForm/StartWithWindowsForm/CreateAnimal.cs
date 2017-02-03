using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
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
        private readonly AnimalsDbContext _context;
        public CreateAnimal(Animal item)
        {
            _context = new AnimalsDbContext();
            InitializeComponent();
            
            FillComboBox();
            tbName.Text = item.Name;
            cbSize.SelectedItem = (object)item.Size;
            _animalId = item.Id;
            _state = ElementState.Edit;

            this.Text = $"Edit animal {item.Name}";
        }

        public CreateAnimal()
        {
            _context = new AnimalsDbContext();
            InitializeComponent();
            FillComboBox();
            _state = ElementState.New;

            this.Text = "Create new animal";
        }

        private void FillComboBox()
        {
            object[] elements = Enum.GetValues(typeof(AnimalSize)).Cast<object>().ToArray();
            cbSize.Items.AddRange(elements);
            cbSize.SelectedIndex = 0;
        }

        private void CreateAnimal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                var editedAnimal = _context.Animals.FirstOrDefault(x => x.Id == _animalId);

                if (editedAnimal == null)
                {
                    editedAnimal = new Animal();
                }

                editedAnimal.Name = tbName.Text.Trim();
                editedAnimal.Size = (AnimalSize)cbSize.SelectedItem;

                _context.Animals.AddOrUpdate(editedAnimal);
                _context.SaveChanges();
            }
        }
    }
}
