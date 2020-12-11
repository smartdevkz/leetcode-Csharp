using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy112
{
    class Solution
    {
        public bool HasPathSum(TreeNode root, int sum)
        {
            if (root == null) return false;
            return HasSum(root, 0, sum);
        }

        private bool HasSum(TreeNode node, int s, int sum)
        {
            s += node.val;
            if (node.left == null && node.right == null && s == sum) return true;
            return (node.left != null && HasSum(node.left, s, sum)) || (node.right != null && HasSum(node.right, s, sum));
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
