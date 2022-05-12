using System;

namespace AlgoExpert.HeightBalancedBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
			BinaryTree root = new BinaryTree(1);
			root.left = new BinaryTree(2);
			root.right = new BinaryTree(3);
			root.left.left = new BinaryTree(4);
			root.left.right = new BinaryTree(5);
			root.right.right = new BinaryTree(6);
			root.left.right.left = new BinaryTree(7);
			root.left.right.right = new BinaryTree(8);
			root.right.right.left  = new BinaryTree(9);
			root.right.right.right = new BinaryTree(10);
			bool expected = true;
			var actual = new Program().HeightBalancedBinaryTree(root);
			Console.WriteLine(expected == actual ? "Balanced" : "Not Balanced");
		}
		public bool HeightBalancedBinaryTree(BinaryTree tree)
		{
			InfoTree infoTree = GetInfoTree(tree);
			return infoTree.Balanced;
		}
		public InfoTree GetInfoTree(BinaryTree node)
        {
			//check if the node is null
			if (node == null)
				return new InfoTree { Balanced = true, Height = -1 };

			//if (node.left == null && node.right == null)
			//	return new InfoTree { Balanced = true, Height = 0 };
			//var infoTree = new InfoTree { Height = 1 };
			var infoLeft = GetInfoTree(node.left);
			var infoRight = GetInfoTree(node.right);
			Console.WriteLine("value " + node.value);
			if (node.left != null)
				Console.WriteLine("left " + node.left.value);
			Console.WriteLine("left info" + infoLeft.Height);
			if (node.right != null)
				Console.WriteLine("right " + node.right.value);
			Console.WriteLine("right info" + infoRight.Height);
			Console.WriteLine("ABS " + Math.Abs(infoLeft.Height - infoRight.Height));
			Console.WriteLine(infoLeft.Height - infoRight.Height);
			return new InfoTree
			{
				Balanced = infoLeft.Balanced && infoRight.Balanced && Math.Abs(infoLeft.Height - infoRight.Height) <= 1,
				Height = infoLeft.Height > infoRight.Height ? infoLeft.Height + 1 : infoRight.Height + 1
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
