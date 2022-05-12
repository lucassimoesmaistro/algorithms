using System;

namespace AlgoExpert.HeightBalancedBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
			BinaryTree root = new BinaryTree(1);
			root = new Program.BinaryTree(1);
			root.left = new Program.BinaryTree(2);
			root.right = new Program.BinaryTree(3);
			root.left.left = new Program.BinaryTree(4);
			root.left.right = new Program.BinaryTree(5);
			root.right.right = new Program.BinaryTree(6);
			root.left.right.left = new Program.BinaryTree(7);
			root.left.right.right = new Program.BinaryTree(8);
			bool expected = true;
			var actual = new Program().HeightBalancedBinaryTree(root);
			Console.WriteLine(expected == actual ? "Balanced" : "Not Balanced");
		}
		public bool HeightBalancedBinaryTree(BinaryTree tree)
		{
			InfoTree infoTree = GetInfoTree(tree);
			return infoTree.Balanced && infoTree.Height < 2;
		}
		public InfoTree GetInfoTree(BinaryTree node)
        {
			if (node.left == null && node.right == null)
				return new InfoTree { Balanced = true, Height = 0 };
			var infoTree = new InfoTree { Height = 1 };
			var infoLeft = GetInfoTree(node.left);
			var infoRight = GetInfoTree(node.right);
			return new InfoTree
			{
				Balanced = infoLeft.Balanced && infoRight.Balanced,
				Height = infoLeft.Height > infoRight.Height ? infoLeft.Height : infoRight.Height
			};
		}
		public class InfoTree
        {
            public bool Balanced { get; set; }
            public int Height { get; set; }
        }
		public class BinaryTree
		{
			public int value;
			public BinaryTree left = null;
			public BinaryTree right = null;

			public BinaryTree(int value)
			{
				this.value = value;
			}
		}

	}
}
