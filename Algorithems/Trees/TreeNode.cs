using System.Runtime.CompilerServices;

namespace Algorithems.Trees
{
    public class TreeNode
    {
        public string value;
        public List<TreeNode> Children { get; set; } = new List<TreeNode>();

        public TreeNode(string value)
        {
            this.value = value;
        }

        public void AddChild(TreeNode child)
        {
            Children.Add(child);
        }
    }

    public class RunTreeNode
    {


        public static void Run()
        {
            TreeNode root = new TreeNode("Hossein");
            TreeNode omid = new TreeNode("Omid");
            TreeNode saeed = new TreeNode("Saeed");
            TreeNode vahid = new TreeNode("Vahid");
            TreeNode saleh = new TreeNode("Saleh");
            TreeNode samyar = new TreeNode("Samyar");

            root.AddChild(omid);
            root.AddChild(saeed);
            root.AddChild(vahid);
            omid.AddChild(saleh);
            omid.AddChild(samyar);
            PrintTree(root, 0);

        }

        public static void PrintTree(TreeNode node, int level)
        {
            Console.WriteLine(new string('-', level * 2) + node.value);

            foreach (var child in node.Children)
            {
                PrintTree(child, level + 1);
            }
        }
    }
}