# Graphs

## Problems

### Node Counting

The candidate is typically given the Interface and shell for the BinaryTreeNodeCounter and is asked to implement the binary tree and node counting logic.
+1 if the candidate uses unit tests instead

An acceptible implementation of the node counting logic might be similar to the following;

```c#
public sealed class BinaryTree<T> : IBinaryTree<T>
{
    public BinaryTree(T Data)
    {
        this.Data = Data;
    }

    public BinaryTree(IBinaryTree<T> Left,
                      IBinaryTree<T> Right,
                      T Data)
    {
        this.Left = Left;
        this.Right = Right;
        this.Data = Data;
    }

    public IBinaryTree<T> Left { get; set; }
    public IBinaryTree<T> Right { get; set; }

    public T Data { get; set; }
}

public static class BinaryTreeNodeCounter 
{ 
    public static int CountNodes<T>(this IBinaryTree<T> tree) 
    { 
        return tree == null 
            ? 0 
            : 1 + tree.Left.CountNodes() + tree.Right.CountNodes(); 
    } 
}

[TestClass]
public class BinaryTreeUnitTests
{
    [TestMethod]
    public void TestNodeCounting()
    {
        IBinaryTree<string> tree = new BinaryTree<string>(Data: "root")
        {
            Left = new BinaryTree<string>(Data: "L1") {
                Left = new BinaryTree<string>(Data: "L1L1")
            },
            Right = new BinaryTree<string>(null, null, "R1")
        };

        var node_count = tree.CountNodes();
        Assert.AreEqual(4, node_count);
    }

    [TestMethod]
    public void TestNodeCountingWithNulls()
    {
        IBinaryTree<string> tree = new BinaryTree<string>(Data: "root")
        {
            Left = null,
            Right = null
        };

        var node_count = tree.CountNodes();
        Assert.AreEqual(1, node_count);
    }
}
```