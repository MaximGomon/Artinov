using System.Windows.Forms;
using System;
using System.Linq;

namespace StartWithWindowsForm
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
            InitializeComponent();
            FillListView();
        }

        private void FillListView()
        {
            lvAnimals.Items.Clear(); //Clear all existing items in ListView
            int animalsCount = AnimalStorage.Animals.Count;

            for (int i = 0; i < animalsCount; i++)
            {
                var animal = AnimalStorage.Animals[i];

                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(animal.Name);
                item.SubItems.Add(animal.Size.ToString());
                item.SubItems.Add(animal.Id.ToString());

                lvAnimals.Items.Add(item);//Add new item to ListView
            }
        }

        private void createAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateAnimal createForm = new CreateAnimal();//Show form for create 
                                                         //new animal
            if (createForm.ShowDialog() == DialogResult.OK)
            {
                //if animal created successed refill ListView
                FillListView();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectedAnimalCount = lvAnimals.SelectedItems.Count;
            if (selectedAnimalCount != 0)
            {
                ListViewItem selectedAnimal = lvAnimals.SelectedItems[0];
                Guid selectedId = Guid.Parse(selectedAnimal.SubItems[3].Text);
                Animal animal = AnimalStorage.Animals.First(x => x.Id == selectedId);

                CreateAnimal editForm = new CreateAnimal(animal);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    FillListView();
                }
            }
        }
    }
}
