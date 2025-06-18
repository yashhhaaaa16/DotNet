namespace Question17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Console.WriteLine("");
            Console.WriteLine("1 1");
            Console.WriteLine("2 1 1 2");
            Console.WriteLine("3 2 1 1 3");*/

            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"{i}  ");

                if (i == 1)
                {
                    Console.Write($"{1}");
                }
                else
                {
                    for (int j = i - 1; j >= 1; j--)
                    {
                        Console.Write($"{j}  ");
                    }

                    Console.Write($"{1}  ");

                    if (i != 1)
                    {
                        Console.Write($"{i}");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
