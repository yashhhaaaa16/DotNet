namespace LinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linked = new LinkedList();
            linked.InsertFirst(1);
            linked.InsertFirst(2);
            linked.InsertLast(3);
            linked.InsertLast(4);
            linked.Display();
            Console.WriteLine(linked.DeleteLast());
            linked.Display();
        }
    }
}
