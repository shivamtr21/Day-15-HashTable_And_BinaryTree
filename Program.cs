namespace HashTableAndBinaryTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to the Hash Table and Bst problem*****");
            BinarySearchTree<int> obj = new BinarySearchTree<int>(256);
            obj.Add(230);
            obj.Add(270);
            obj.Display();
        }
    }
}
