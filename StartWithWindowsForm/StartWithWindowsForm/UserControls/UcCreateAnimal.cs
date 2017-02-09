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
        public UcCreateAnimal(List<AnimalType> animalTypes)
        {
            InitializeComponent();
            FillComboBox();
            FillAnimalTypes(animalTypes);
        }

        private void FillAnimalTypes(List<AnimalType> animalTypes)
        {
            //Создаем список корневых елементов дерева и записываем в него те элементы
            //которые в базе данных не имеют родительского элемента 
            List<AnimalType> coreNodes = animalTypes.Where(x => x.Parent == null).ToList();
            //проходим по списку корневых элементов
            foreach (var node in coreNodes)
            {
                //создаем элемент дерева
                TreeNode coreNode = new TreeNode(node.Name);
                //записываем в тег элемента его айди в базе 
                //(для последующей идентификации выбраного элемента на форме)
                coreNode.Tag = node.Id;
                //Вызываем рекурсивную функцыю для заполнения ветвей и листов дерева
                RecursionFillTreeViewNodes(animalTypes, node.Id, coreNode);
                //добавляем к контролу tvAnimalTypes созданный ранее элемент дерева
                tvAnimalTypes.Nodes.Add(coreNode);
            }
        }

        private void RecursionFillTreeViewNodes(List<AnimalType> animalTypes, Guid parentId, TreeNode parentNode)
        {
            //Получаем список всех дочерних типов для текущего типа
            List<AnimalType> childTypes = animalTypes.Where(x => x.Parent?.Id == parentId).ToList();
            //проходим по списку дочерних типов
            foreach (var animalType in childTypes)
            {
                //создаем елемент дерева для текущего типа
                TreeNode currentNode = new TreeNode(animalType.Name);
                //записываем в тег элемента его айди в базе 
                //(для последующей идентификации выбраного элемента на форме)
                currentNode.Tag = animalType.Id;

                //проверяем есть ли типы для которых текущий тип является родительским
                if (animalTypes.Any(x => x.Parent?.Id == animalType.Id))
                {
                    //если есть - рекурсивно вызываем функцию для заполнения элемента дерева
                    RecursionFillTreeViewNodes(animalTypes, animalType.Id, currentNode);
                }

                //добавляем к родительскому элементу дерева текущий элемент
                parentNode.Nodes.Add(currentNode);
            }
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
