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
        private readonly ElementState _state;
        private readonly AnimalsDbContext _context;
        public CreateAnimal(Animal item, AnimalsDbContext context)
        {
            _context = context;
            InitializeComponent();
            var control = new UcEditAnimal(item);
            //control.Dock = DockStyle.Fill;

            splitContainer1.Panel1.Controls.Add(control);
            //splitContainer1.Panel1.Size = control.Size;
            splitContainer1.Panel1.Controls[0].Dock = DockStyle.Fill;
            _state = ElementState.Edit;
            this.Text = $"Edit animal {item.Name}";
        }

        public CreateAnimal(AnimalsDbContext context)
        {
            _context = context;
            InitializeComponent();
            _state = ElementState.New;
            var control = new UcCreateAnimal(_context.AnimalTypes.ToList());
            //control.Dock = DockStyle.Fill;
            //control.Size = new Size(190, 310);
            splitContainer1.Panel1.Controls.Add(control);
            //var s = new Size(control.Size.Width, control.Size.Height);
            //splitContainer1.Panel1.Size = s;
            splitContainer1.Panel1.Controls[0].Dock = DockStyle.Fill;

            this.Text = "Create new animal";
        }

        

        private void CreateAnimal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.OK)
            {
                var editedAnimal = ((IAnimalStorage)splitContainer1.Panel1.Controls[0]).GetAnimal();
                _context.Animals.AddOrUpdate(editedAnimal);
                _context.SaveChanges();
            }
        }
    }
}
