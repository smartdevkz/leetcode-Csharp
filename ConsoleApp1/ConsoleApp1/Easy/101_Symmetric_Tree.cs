using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy101
{
    class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            if (root == null) return true;
            return IsSymmetricPair(root.left, root.right);
        }

        public bool IsSymmetricPair(TreeNode p, TreeNode q)
        {
            if (p == null || q == null) return p == null && q == null;
            return p.val == q.val && IsSymmetricPair(p.left, q.right) && IsSymmetricPair(p.right, q.left);
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
