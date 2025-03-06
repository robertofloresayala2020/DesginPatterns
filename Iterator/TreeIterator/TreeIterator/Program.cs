// See https://aka.ms/new-console-template for more information
using TreeIterator.Class;
using TreeIterator.Model;

Console.WriteLine("Hello, World!");


var root = new TreeNode<int>(1)
{
    Left = new TreeNode<int>(2)
    {
        Left = new TreeNode<int>(4),
        Right = new TreeNode<int>(5)
    },
    Right = new TreeNode<int>(3)
    {
        Left = new TreeNode<int>(6),
        Right = new TreeNode<int>(7)
    }
};

// Recorrer el árbol en orden (in-order)
Console.WriteLine("In-Order Traversal:");
var inOrderIterator = new InOrderIterator<int>(root);
while (inOrderIterator.MoveNext())
{
    Console.WriteLine(inOrderIterator.Current);
}

// Recorrer el árbol en preorden (pre-order)
Console.WriteLine("\nPre-Order Traversal:");
var preOrderIterator = new PreOrderIterator<int>(root);
while (preOrderIterator.MoveNext())
{
    Console.WriteLine(preOrderIterator.Current);
}

// Recorrer el árbol por niveles (level-order)
Console.WriteLine("\nLevel-Order Traversal:");
var levelOrderIterator = new LevelOrderIterator<int>(root);
while (levelOrderIterator.MoveNext())
{
    Console.WriteLine(levelOrderIterator.Current);
}
