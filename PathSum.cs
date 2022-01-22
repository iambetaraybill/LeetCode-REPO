public class Solution {
    public bool HasPathSum(TreeNode root, int sum) {
        if (root == null)
            return false;
        
        if (root.left == null && root.right == null)
            return sum == root.val;
        
        return HasPathSum(root.left, sum - root.val) || HasPathSum(root.right, sum - root.val);
    }
}
