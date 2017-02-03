﻿using System;
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
    public partial class DeleteAnimalForm : Form
    {
        private readonly AnimalsDbContext _context;
        public DeleteAnimalForm()
        {
            _context = new AnimalsDbContext();
            InitializeComponent();
            ShowAllAnimals();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteChoosenAnimal();
        }
    }
}
