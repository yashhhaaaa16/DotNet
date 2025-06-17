namespace Question8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter year : ");
            int i = int.Parse(Console.ReadLine());
            if ( (i % 4 == 0) && ( i % 400 == 0 || i % 100 != 0) )
            {
                Console.WriteLine($"{i} is a Leap Year");
            }
            else
            {
                Console.WriteLine($"{i} is not a Leap Year");
            }
        }
    }
}
