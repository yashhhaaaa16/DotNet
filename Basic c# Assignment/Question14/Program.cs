namespace Question14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Absolute of {num1} is {Math.Abs(num1)}");
        }
    }
}
