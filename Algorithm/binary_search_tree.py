class Node(object):
    def __init__(self, val) -> None:
        self.right = None
        self.left = None
        self.data = val

class BinarySearchTree(object):
    def insert(self, root, node):
        if root is None:
            root = node
        else:
            if root.data > node.data:
                if root.left is None:
                    root.left = node
                else:
                    self.insert(root.left, node)
            else:
                if root.right is None:
                    root.right = node
                else:
                    self.insert(root.right, node)

        return root

    def inorder_print(self, root):
        if not root:
            return
        
        self.inorder_print(root.left)
        print(root.data)
        self.inorder_print(root.right)

    def preorder_print(self, root):
        if not root:
            return

        print(root.data)
        self.preorder_print(root.left)
        self.preorder_print(root.right)

    def postorder_print(self, root):
        if not root:
            return

        self.postorder_print(root.left)
        self.postorder_print(root.right)
        print(root.data)

if __name__ == "__main__":
    r = Node(3)
    node = BinarySearchTree()
    nodeList = [1, 8, 5, 12, 14, 6, 15, 7, 16, 8]
    for nd in nodeList:
        node.insert(r, Node(nd))
    print ("------In order ---------")
    print (node.inorder_print(r))
    print ("------Pre order ---------")
    print (node.preorder_print(r))
    print ("------Post order ---------")
    print (node.postorder_print(r))
