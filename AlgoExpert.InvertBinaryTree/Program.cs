using System;

namespace AlgoExpert.InvertBinaryTree
{
    class Program
    {
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
			root.right.right.left = new BinaryTree(9);
			root.right.right.right = new BinaryTree(10);
			bool expected = true;
			var actual = new Program().Invert(root);
			Console.WriteLine(actual.value);
		}
		public BinaryTree Invert(BinaryTree tree)
		{
			if (tree == null)
				return tree;

			if (tree.left == null && tree.right == null)
				return tree;

			BinaryTree leftLastNode, rightLastNode;

			leftLastNode = Invert(tree.left);
			rightLastNode = Invert(tree.right);

			tree.right = leftLastNode;
			tree.left = rightLastNode;

			return tree;
		}
	}
}
