using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Easy111
{
    class Solution
    {
        public int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            return GetDepth(new List<TreeNode>() { root }, 0);
        }

        public int GetDepth(List<TreeNode> lst, int h)
        {
            h++;
            foreach (var item in lst)
            {
                if (item.left == null && item.right == null) return h;
            }
            List<TreeNode> children = new List<TreeNode>();
            foreach (var item in lst)
            {
                if (item.left != null) children.Add(item.left);
                if (item.right != null) children.Add(item.right);
            }
            return GetDepth(children, h);
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
