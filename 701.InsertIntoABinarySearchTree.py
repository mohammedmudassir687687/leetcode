# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def insertIntoBST(self, root: Optional[TreeNode], val: int) -> Optional[TreeNode]:
        newNode = TreeNode(val, None, None)
        if root:
            if root.val > val:
                if root.left == None:
                    root.left = newNode
                else:
                    self.insertIntoBST(root.left, val)
            elif root.val < val:
                if root.right == None:
                    root.right = newNode
                else:
                    self.insertIntoBST(root.right, val)
        else:
            root = newNode
        return root