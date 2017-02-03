using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StartWithWindowsForm
{
    public partial class MainForm : Form
    {
        private readonly AnimalsDbContext _context;
        public MainForm()
        {
            _context = new AnimalsDbContext();

            InitializeComponent();
            FillListView();
        }

        public void RefreshForm()
        {
            FillListView();
        }

        private void FillListView()
        {
            lvAnimals.Items.Clear(); //Clear all existing items in ListView

            List<Animal> animal = _context.Animals.ToList();
            int animalsCount = animal.Count;

            for (int i = 0; i < animalsCount; i++)
            {
                ListViewItem item = new ListViewItem(i.ToString());
                item.SubItems.Add(animal[i].Name);
                item.SubItems.Add(animal[i].Size.ToString());
                item.SubItems.Add(animal[i].Id.ToString());

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
                Animal animal = _context.Animals.First(x => x.Id == selectedId);

                CreateAnimal editForm = new CreateAnimal(animal);

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    FillListView();
                }
            }
        }

        private void deleteAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isAnimalExists = _context.Animals.Any();
            if (isAnimalExists)
            {
                int selectedAnimal = lvAnimals.SelectedItems.Count;
                if (selectedAnimal != 0)
                {
                    ListViewItem selectedItem = lvAnimals.SelectedItems[0];
                    Guid selectedId = Guid.Parse(selectedItem.SubItems[3].Text);
                    DeleteAnimal(GetAnimalById(selectedId));
                    FillListView();
                }
            }
        }

        private Animal GetAnimalById(Guid selectedId)
        {
            return _context.Animals.First(x => x.Id == selectedId);
        }

        private void DeleteAnimal(Animal deletedAnimal)
        {
            _context.Animals.Remove(deletedAnimal);
            _context.SaveChanges();
        }

        //private void deleteByFormToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    bool isAnimalExists = _context.Animals.Any();
        //    if (isAnimalExists)
        //    {
        //        new DeleteAnimalForm().ShowDialog(this);
        //        FillListView();
        //    }
        //    else
        //    {
        //        MessageBox.Show("There are no animals at this moment");
        //    }
        //}

        private void importFromcsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog() { Filter = "CSV|*.csv", };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(new FileStream(ofd.FileName, FileMode.Open)))
                {
                    List<string> animals = new List<string>();
                    sr.ReadLine();

                    while (!sr.EndOfStream)
                    {
                        animals.Add(sr.ReadLine());
                    }

                    animals.RemoveAt(animals.Count - 1);

                    foreach (var animalItem in animals)
                    {
                        var collection = animalItem.Split(',');
                        Animal animal = new Animal()
                        {
                            Name = collection[1],
                            Size = (AnimalSize)Enum.Parse(typeof(AnimalSize), collection[2])
                        };
                        _context.Animals.Add(animal);
                        
                    }
                    sr.Close();
                }
                _context.SaveChanges();

                FillListView();
            }
        }

        private void expotrTocsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!_context.Animals.Any())
            {
                MessageBox.Show("There are no animals, cannot create file!");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(sfd.FileName, FileMode.Create)))
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("#,Name,Size");
                    foreach (ListViewItem item in lvAnimals.Items)
                    {
                        sb.AppendLine($"{item.SubItems[0].Text},{item.SubItems[1].Text},{item.SubItems[2].Text}");
                    }
                    sw.WriteLine(sb.ToString());
                    sw.Close();
                }

                MessageBox.Show("Saved");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var box = new AboutBox().ShowDialog();
        }
    }
}
