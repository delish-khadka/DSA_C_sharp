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

    // Breadth First Search (Level-order traversal)
    public void LevelOrderTraversal(Node node)
    {
        if (node == null) return;

        Queue<Node> queue = new Queue<Node>();  // Create a queue to store nodes at each level
        queue.Enqueue(node);  // Start with the root node

        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();  // Dequeue the next node
            Console.Write(current.Value + " ");  // Process the current node

            // Enqueue the left child if it exists
            if (current.Left != null)
            {
                queue.Enqueue(current.Left);
            }

            // Enqueue the right child if it exists
            if (current.Right != null)
            {
                queue.Enqueue(current.Right);
            }
        }
    }

    // function to search a key in a BST
    public bool Search(Node root, int key)
    {
        // Base Cases: root is null or key is
        // present at root
        if (root == null )
            return false;
        
        if(key == root.Value)
            return true;

        // Key is greater than root's key
        if (root.Value < key)
            return Search(root.Right, key);

        // Key is smaller than root's key
        return Search(root.Left, key);
    }

    // Recursive method to delete a node from the BST
    public Node Delete(Node current, int value)
    {
        // Step 1: Base case - If the tree is empty or node is not found
        if (current == null)
        {
            return current;
        }

        // Step 2: Traverse the tree to find the node to delete
        if (value < current.Value)
        {
            // Go left if the value to be deleted is smaller than the current node's value
            current.Left = Delete(current.Left, value);
        }
        else if (value > current.Value)
        {
            // Go right if the value to be deleted is larger than the current node's value
            current.Right = Delete(current.Right, value);
        }
        else
        {
            // Node to be deleted is found

            // Case 1: Node has no children (leaf node)
            if (current.Left == null && current.Right == null)
            {
                return null;
            }
            // Case 2: Node has one child (left or right)
            else if (current.Left == null)
            {
                return current.Right; // Return the right child
            }
            else if (current.Right == null)
            {
                return current.Left;  // Return the left child
            }

            // Case 3: Node has two children
            // Find the in-order successor (smallest node in the right subtree)
            Node successor = FindMin(current.Right);

            // Copy the successor's value to the current node
            current.Value = successor.Value;

            // Delete the in-order successor (it will have at most one child)
            current.Right = Delete(current.Right, successor.Value);
        }

        // Return the (potentially updated) node pointer
        return current;
    }

    // Helper function to find the minimum value node (used for in-order successor)
    private Node FindMin(Node current)
    {
        while (current.Left != null)
        {
            current = current.Left;
        }
        return current;
    }

    // Method to calculate the height of the binary tree
    public int GetHeight(Node node)
    {
        if (node == null)
        {
            return -1; // Base case: height of an empty tree is -1
        }

        // Recursively calculate the height of the left and right subtrees
        int leftHeight = GetHeight(node.Left);
        int rightHeight = GetHeight(node.Right);

        // Return the maximum height between the two subtrees + 1 for the current node
        return Math.Max(leftHeight, rightHeight) + 1;
    }

    // Recursive method to calculate the depth of a specific node
    public int GetDepth(Node current, int value, int currentDepth)
    {
        // Base case: if the current node is null, return -1 (node not found)
        if (current == null)
        {
            return -1;
        }

        // If the current node holds the value we are looking for, return the current depth
        if (current.Value == value)
        {
            return currentDepth;
        }

        // Search in the left subtree
        int leftDepth = GetDepth(current.Left, value, currentDepth + 1);
        if (leftDepth != -1)
        {
            return leftDepth; // If found in the left subtree, return the depth
        }

        // Search in the right subtree
        return GetDepth(current.Right, value, currentDepth + 1); // If not found in left, check right
    }

    // Helper function to start depth calculation from the root
    public int GetDepth(int value)
    {
        return GetDepth(Root, value, 0); // Start the search from the root, with depth 0
    }
}
