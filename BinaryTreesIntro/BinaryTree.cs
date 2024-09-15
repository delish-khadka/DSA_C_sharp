namespace BinaryTreesIntro;

public class BinaryTree
{
    public Node Root;  // The root node of the binary tree

    // Constructor to initialize an empty tree
    public BinaryTree()
    {
        Root = null;
    }

    // Method to manually insert nodes
    public void InsertManually(int value, string position, Node parent = null)
    {
        if (Root == null)
        {
            // If tree is empty, make this node the root
            Root = new Node(value);
        }
        else if (position == "left")
        {
            parent.Left = new Node(value);
        }
        else if (position == "right")
        {
            parent.Right = new Node(value);
        }
    }

    // Preorder traversal to display the tree
    public void PreOrderTraversal(Node node)
    {
        if (node == null) return;

        Console.Write(node.Value + " ");  // Visit the root
        PreOrderTraversal(node.Left);     // Traverse left subtree
        PreOrderTraversal(node.Right);    // Traverse right subtree
    }
}

