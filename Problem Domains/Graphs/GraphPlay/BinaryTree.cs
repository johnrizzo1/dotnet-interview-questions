namespace GraphPlay
{
    public sealed class BinaryTree<T> : IBinaryTree<T>
    {
        public BinaryTree() {}

        public BinaryTree(T Data)
        {
            this.Data = Data;
        }

        public BinaryTree(IBinaryTree<T> Left,
                          IBinaryTree<T> Right)
        {
            this.Left = Left;
            this.Right = Right;
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
}