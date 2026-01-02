/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

// // BFS
// public class Solution {
//     public int MaxDepth(TreeNode root) {
//     if (root == null) return 0;

//     Queue<TreeNode> queue = new();
//     queue.Enqueue(root);
//     int depth = 0;

//     while (queue.Count > 0) {
//         int levelSize = queue.Count; // nodes at this level
//         depth++;
        
//         // Now we add everything in this level to the queue
//         for (int i = 0; i < levelSize; i++) {
//             TreeNode node = queue.Dequeue();

//             if (node.left != null)
//                 queue.Enqueue(node.left);
//             if (node.right != null)
//                 queue.Enqueue(node.right);
//         }
//     }

//     return depth;
// }

// }


//Recursive DFS
public class Solution {
    public int MaxDepth(TreeNode root) {
        if (root == null) {
            return 0;
        }

        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}

// Iterative DFS Solution
// public class Solution {
//     public int MaxDepth(TreeNode root) {
//         if(root == null){
//             return 0;
//         }
//         int maxDepth = 0;
//         Stack<(TreeNode node, int currDepth)> stack = new Stack<(TreeNode node, int currDepth)>();
//         stack.Push((root, 1));

//         while(stack.Count > 0){
//             var(node, currDepth)  = stack.Pop();
//             if(currDepth > maxDepth){
//                 maxDepth = currDepth;
//             }
//             if(node.right != null){
//                 stack.Push((node.right, currDepth + 1));
//             }
//             if(node.left != null){
//                 stack.Push((node.left, currDepth + 1));
//             }
//         }
//         return maxDepth;
//     }
// }
