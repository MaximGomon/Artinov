using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace StartWithWindowsForm
{
    public partial class MainForm : System.Windows.Forms.Form
    {
        public MainForm()
        {
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

        private void deleteAnimalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int animalCount = AnimalStorage.Animals.Count;
            if (animalCount != 0)
            {
                int selectedAnimal = lvAnimals.Items.Count;
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
            return AnimalStorage.Animals.First(x => x.Id == selectedId);
        }

        private void DeleteAnimal(Animal deletedAnimal)
        {
            AnimalStorage.Animals.Remove(deletedAnimal);
        }

        private void deleteByFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int animalCount = AnimalStorage.Animals.Count;
            if (animalCount != 0)
            {
                new DeleteAnimalForm().ShowDialog(this);
                FillListView();
            }
            else
            {
                MessageBox.Show("There are no animals at this moment");
            }
        }

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
                        AnimalStorage.Animals.Add(animal);
                    }
                    sr.Close();
                }

                FillListView();
            }
        }

        private void expotrTocsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (AnimalStorage.Animals.Count == 0)
            {
                MessageBox.Show("There are no animals,cannot create file!");
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
    }
}
