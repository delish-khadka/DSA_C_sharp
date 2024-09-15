// See https://aka.ms/new-console-template for more information
using BinaryTreesIntro;


        // Create the binary tree
        BinaryTree tree = new BinaryTree();

        // Manually insert nodes (no comparison)
        tree.InsertManually(1, "left");     // 1 is the root
        tree.InsertManually(2, "left", tree.Root);  // 2 is the left child of root
        tree.InsertManually(3, "right", tree.Root); // 3 is the right child of root
        tree.InsertManually(4, "left", tree.Root.Left);  // 4 is the left child of 2
        tree.InsertManually(5, "right", tree.Root.Left); // 5 is the right child of 2

        // Perform preorder traversal
        Console.WriteLine("Preorder Traversal of General Binary Tree:");
        tree.PreOrderTraversal(tree.Root);


