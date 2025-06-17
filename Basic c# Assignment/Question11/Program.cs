namespace Question11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Second Number : ");
            int num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter Third Number : ");
            int num3 = int.Parse(Console.ReadLine());

            int max = 0;

            if (num1 > num2 && num2 > num3)
            {
                max = num1;
            }
            else if (num2 > num3)
            {
                max = num2;
            }
            else
            {
                max = num3;
            }
            Console.WriteLine($"Maximum Number is {max}");
        }
    }
}
