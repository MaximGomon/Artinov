using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartWithWindowsForm
{
    partial class DeleteAnimalForm
    {
        void ShowAllAnimals()
        {
            foreach (var animal in _context.Animals)
            {
                AnimalsListBox.Items.Add(animal);
            }
        }

        void DeleteChoosenAnimal()
        {
            int choosenAnimalIndex = AnimalsListBox.SelectedIndex;
            if (choosenAnimalIndex != -1)
            {
                AnimalStorage.Animals.RemoveAt(choosenAnimalIndex);
                AnimalsListBox.Items.Clear();
                ShowAllAnimals();
            }
        }
    }
}
