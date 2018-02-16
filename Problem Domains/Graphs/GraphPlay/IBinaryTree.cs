namespace GraphPlay
{
    public interface IBinaryTree<T>
    {
        IBinaryTree<T> Left { get; }
        IBinaryTree<T> Right { get; }
        T Data { get; }
    }
}