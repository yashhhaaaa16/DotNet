namespace Question6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Character : ");
            char ch = char.Parse(Console.ReadLine());
            int a = ch;
            Console.WriteLine($"Ascii value of {ch} is {a}");
        }
    }
}
