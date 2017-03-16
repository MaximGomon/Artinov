using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Artinov.StageOne.SkiCenterManagementSystem.Helpers;
using Artinov.StageOne.SkiCenterManagementSystem.SkiServiceReference;

namespace Artinov.StageOne.SkiCenterManagementSystem
{
    public partial class SelectEquipmentForm : Form
    {
        public SelectEquipmentForm()
        {
            InitializeComponent();
            FillTreeView();
        }

        private void FillTreeView()
        {
            EquipmentType[] allTypes = ServiceHelper.Client.GetEquipmentTypes();
            List<EquipmentType> coreNodes = allTypes.Where(x => x.ParentEquipmentType == null).ToList();

            foreach (var node in coreNodes)
            {
                TreeNode coreNode = new TreeNode(node.Name);
                coreNode.Tag = node.Id;
                RecursionFillTreeViewNodes(allTypes, node.Id, coreNode);
                tvTypes.Nodes.Add(coreNode);
            }
        }

        private void RecursionFillTreeViewNodes(EquipmentType[] types, Guid parentId, TreeNode parentNode)
        {
            List<EquipmentType> childTypes = types.Where(x => x.ParentEquipmentType?.Id == parentId).ToList();
            foreach (var animalType in childTypes)
            {
                TreeNode currentNode = new TreeNode(animalType.Name);
                currentNode.Tag = animalType.Id;

                if (types.Any(x => x.ParentEquipmentType?.Id == animalType.Id))
                {
                    RecursionFillTreeViewNodes(types, animalType.Id, currentNode);
                }
                parentNode.Nodes.Add(currentNode);
            }
        }
    }
}
