namespace Algorithems.Trees
{
    public class BinaryNode
    {
        public int Value;
        public BinaryNode left;
        public BinaryNode right;

        public BinaryNode(int value)
        {
            Value = value;
        }


        public static void Run()
        {
            var root = new BinaryNode(1);
            root.left = new BinaryNode(2);
            root.right = new BinaryNode(3);
            root.left.left = new BinaryNode(4);
            root.left.right = new BinaryNode(5);
            root.right.right = new BinaryNode(6);
        }
    }
}