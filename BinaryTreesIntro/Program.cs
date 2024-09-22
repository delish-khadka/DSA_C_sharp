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

Console.WriteLine();
// Create the binary search tree
BinarySearchTree bst = new BinarySearchTree();

// Insert nodes (automatically placed based on value comparisons)
bst.Insert(5);
bst.Insert(3);
bst.Insert(7);
bst.Insert(2);
bst.Insert(4);
bst.Insert(6);
bst.Insert(8);

// Perform inorder traversal
Console.WriteLine("Inorder Traversal of Binary Search Tree (BST):");
bst.InOrderTraversal(bst.Root);

Console.WriteLine();
// Perform preorder traversal
Console.WriteLine("PreOrder Traversal of Binary Search Tree (BST):");
bst.PreOrderTraversal(bst.Root);

Console.WriteLine();

// Perform postorder traversal
Console.WriteLine("PostOrder Traversal of Binary Search Tree (BST):");
bst.PostOrderTraversal(bst.Root);

Console.WriteLine();

//Perform BFS
Console.WriteLine("BFS Traversal of Binary Search Tree (BST):");
bst.LevelOrderTraversal(bst.Root);

Console.WriteLine();
//Searching in BST
Console.WriteLine("searching for a value in BST: ");
Console.WriteLine(bst.Search(bst.Root,4));

Console.WriteLine();
//Deleting a node in BST
Console.WriteLine("deleting node 7 in BST");
bst.Delete(bst.Root,7);

// Perform inorder traversal
Console.WriteLine("Inorder Traversal of Binary Search Tree (BST):");
bst.InOrderTraversal(bst.Root);

Console.WriteLine();
Console.WriteLine(bst.GetHeight(bst.Root));


Console.WriteLine(bst.GetDepth(80));

Console.WriteLine("Is the unbalanced BST balanced? " + bst.IsBalanced(bst.Root));