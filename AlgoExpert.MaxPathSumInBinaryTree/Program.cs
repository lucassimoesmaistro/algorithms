using System;

namespace AlgoExpert.MaxPathSumInBinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
		{
			BinaryTree root = new BinaryTree(1);
			root.left = new BinaryTree(2);
			root.right = new BinaryTree(3);
			root.left.left = new BinaryTree(4);
			root.left.right = new BinaryTree(5);
			root.right.right = new BinaryTree(6);
			root.right.left = new BinaryTree(7);

			//BinaryTree root = new BinaryTree(1);
			//root.left = new BinaryTree(-5);
			//root.right = new BinaryTree(3);
			//root.left.left = new BinaryTree(6);

			var max = MaxPathSum(root);
			Console.WriteLine(max);
		}
		public static int MaxPathSum(BinaryTree tree)
		{
			int leftSum = MaxBranchPathSum(tree.left);
			int rightSum = MaxBranchPathSum(tree.right);
			int sum = Math.Max(leftSum + tree.value, tree.value);
			sum = Math.Max(rightSum + sum, sum);

			return sum;
		}
		public static int MaxBranchPathSum(BinaryTree tree)
		{
			if (tree.left == null && tree.right == null)
				return tree.value;

			int max = Math.Max(MaxBranchPathSum(tree.left), MaxBranchPathSum(tree.right));
			max = Math.Max(max + tree.value, tree.value);

			return max;
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
