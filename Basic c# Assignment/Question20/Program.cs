namespace Question20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number of terms : ");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 0;
            Console.WriteLine($"{a}\n");
            Console.WriteLine($"{b}\n");

            for (int i = 0; i < n-2; i++)
            {
                c = a + b;
                Console.WriteLine($"{c}\n");
                a = b; b = c;
            }
        }
    }
}
