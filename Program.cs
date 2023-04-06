namespace BinaryTreeDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures and Algorithm Problems");



            Binarytree binaryTree = new Binarytree();

            binaryTree.Add(65);
            binaryTree.Add(70);
            binaryTree.Add(60);
            binaryTree.Add(50);
            binaryTree.Add(30);
            binaryTree.Add(85);
            binaryTree.Add(10);
            binaryTree.Add(95);

            binaryTree.TravarsePreorder(binaryTree.Root);

            

        }
    }
}