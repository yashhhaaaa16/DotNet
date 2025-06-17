namespace Question5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine($"First Number = {a}");
            Console.WriteLine($"Second Number = {b}");
            int t = a;
            a = b;
            b = t;

            Console.WriteLine("After swap ===>>>");
            Console.WriteLine();
            Console.WriteLine($"First Number = {a}");
            Console.WriteLine($"Second Number = {b}");

        }
    }
}
