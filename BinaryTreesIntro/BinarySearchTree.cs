using System;

namespace BinaryTreesIntro;

public class BinarySearchTree
{
    public Node Root;  // The root node of the binary search tree

    // Constructor to initialize an empty tree
    public BinarySearchTree()
    {
        Root = null;
    }

    // Method to insert a node based on comparison
    public void Insert(int value)
    {
        Root = InsertRecursive(Root, value);
    }

    // Recursive method to handle insertion based on comparisons
    private Node InsertRecursive(Node current, int value)
    {
        if (current == null)
        {
            return new Node(value);  // Insert the new node at the correct position
        }

        if (value < current.Value)
        {
            current.Left = InsertRecursive(current.Left, value);
        }
        else if (value > current.Value)
        {
            current.Right = InsertRecursive(current.Right, value);
        }

        return current;  // Return the unchanged node pointer
    }

    // Inorder traversal to display the tree (values in ascending order)
    public void InOrderTraversal(Node node)
    {
        if (node == null) return;

        InOrderTraversal(node.Left);    // Traverse left subtree
        Console.Write(node.Value + " ");  // Visit the root
        InOrderTraversal(node.Right);   // Traverse right subtree
    }

    // Preorder traversal: Root -> Left subtree -> Right subtree
    public void PreOrderTraversal(Node node)
    {
        if (node == null) return;

        Console.Write(node.Value + " ");  // Visit the root node
        PreOrderTraversal(node.Left);  // Traverse the left subtree
        PreOrderTraversal(node.Right);  // Traverse the right subtree
    }

    // Postorder traversal: Left subtree -> Right subtree -> Root
    public void PostOrderTraversal(Node node)
    {
        if (node == null) return;

        PostOrderTraversal(node.Left);  // Traverse the left subtree
        PostOrderTraversal(node.Right);  // Traverse the right subtree
        Console.Write(node.Value + " ");  // Visit the root node
    }
}
