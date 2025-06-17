namespace Question2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Five Numbers : ");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int n3 = int.Parse(Console.ReadLine());
                int n4 = int.Parse(Console.ReadLine());
                int n5 = int.Parse(Console.ReadLine());

                int avg = (n1 + n2 + n3 + n4 + n5) / 5;
                Console.WriteLine($"Average is {avg}");
            }
            catch (Exception e)
            {
                Console.WriteLine("Please Enter inetger only !!");
            }
        }
    }
}
